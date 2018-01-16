using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Services;
using Services.ViewModel;
using static Domain.Enums;

namespace Archaeomania
{
    public partial class BirdDetails : Form
    {
        private readonly IBirdService _birdService;
        private readonly Archaeomania _mainForm;
        private readonly IUnitOfMeasurementService _unitOfMeasurementService;
        public UnitOfMeasurement Um;
        public Bird Bird;
        #region Constructor
        public BirdDetails(IBirdService birdService, Archaeomania mainForm, IUnitOfMeasurementService unitOfMeasurementService)
        {
            _birdService = birdService;
            _mainForm = mainForm;
            _unitOfMeasurementService = unitOfMeasurementService;
            if (Bird == null)
                Bird = new Bird();
            InitializeComponent();
        }
        #endregion
        #region private methods
        private void BirdDetails_Load(object sender, EventArgs e)
        {
            try
            {
                cmbUM.DataSource = Enum.GetValues(typeof(UnitOfMeasurement));
                cmbUM.SelectedText = Um.ToString();
                cmbSkeletonType.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error:" + ex.Message);
            }
        }

        private double CalculateUm()
        {
            try
            {
                Um = cmbUM.SelectedValue as UnitOfMeasurement? ?? UnitOfMeasurement.Milliarchieops;
                switch (Um)
                {
                    case UnitOfMeasurement.Centimeters:
                        return _unitOfMeasurementService.FromCentimetersToMilliarchieops();
                    case UnitOfMeasurement.Inches:
                        return _unitOfMeasurementService.FromInchesToMilliarchieops();
                    default:
                        return 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error:" + ex.Message);
                return 0;
            }
        }

        private Bird BirdFromFields()
        {
            try
            {
                Bird.Id = lblId.Text == "" ? _birdService.GetNextId() : Convert.ToInt16(lblId.Text);
                Bird.BirdType = BirdType.Archie;
                if (txtGirth.Text != "")
                    Bird.Girth = Convert.ToDouble(txtGirth.Text)*CalculateUm();
                if (txtHeight.Text != "")
                    Bird.Height = Convert.ToDouble(txtHeight.Text)*CalculateUm();
                if (txtLength.Text != "")
                    Bird.Length = Convert.ToDouble(txtLength.Text)*CalculateUm();
                Bird.SpecimenName = txtSpecimenName.Text;
                if (txtWeight.Text != "")
                    Bird.Weight = Convert.ToDouble(txtWeight.Text);
                if (Bird.Location == null)
                    Bird.Location = new Location
                    {
                        Altitude = txtAltitude.Text,
                        Latitude = txtLatitude.Text,
                        Longitude = txtLongitude.Text,
                        Name = txtName.Text
                    };
                if (Bird.Skeleton == null)
                    Bird.Skeleton = new Skeleton();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error:" + ex.Message);
            }
            return Bird;
        }

        private void btnUpdateBird_Click(object sender, EventArgs e)
        {
            try
            {
                Bird = BirdFromFields();
                if (lblId.Text == "")
                    _birdService.AddBird(Bird);
                else
                    _birdService.UpdateBird(Bird);
                lblId.Text = "";
                _mainForm.BindBirds();
                if (Bird.Id != null) _birdService.GetSpecificBird(Bird.Id.Value);
                var message = "Bird Saved.";
                message += Bird.Wingspan == null
                    ? " Both wings are missing. Can't calculate wingspan."
                    : " Calculated wingspan is " + Bird.Wingspan;
                MessageBox.Show(message);
                Close();
                Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error:"+ ex.Message);
            }
        }

        private void cmbUm_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                UnitOfMeasurement um = cmbUM.SelectedValue as UnitOfMeasurement? ?? UnitOfMeasurement.Milliarchieops;
                double unitTimes = _unitOfMeasurementService.ConvertUnit(um);
                if (txtHeight.Text != "")
                    txtHeight.Text = Math.Round(Convert.ToDouble(txtHeight.Text)*unitTimes, 2).ToString(CultureInfo.InvariantCulture);
                if (txtLength.Text != "")
                    txtLength.Text = Math.Round((Convert.ToDouble(txtLength.Text)*unitTimes), 2).ToString(CultureInfo.InvariantCulture);
                if (txtGirth.Text != "")
                    txtGirth.Text = Math.Round((Convert.ToDouble(txtGirth.Text)*unitTimes), 2).ToString(CultureInfo.InvariantCulture);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error:" + ex.Message);
            }
        }

        private void btnAddSkeleton_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSkeletonValue.Text == "")
                {
                    MessageBox.Show(@"Enter a value for skeleton type");
                    return;
                }
                string message;
                Bird = _birdService.AddBoneToSkeleton(Bird, cmbSkeletonType.Text, txtSkeletonValue.Text, out message);
                if (message != "")
                    MessageBox.Show(message);
                txtSkeletonValue.Text = "";
                UpdateSkeletonList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error:" + ex.Message);
            }
        }

        private void cmbSkeletonType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                UpdateSkeletonList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error:" + ex.Message);
            }
        }

        private void UpdateSkeletonList()
        {
            try
            {
                lstSkeleton.Items.Clear();
                switch (cmbSkeletonType.Text)
                {
                    case "Wings":
                    {
                        for (int i = 0; i < Bird.Skeleton?.Wings?.Count; i++)
                            lstSkeleton.Items.Add(Bird.Skeleton.Wings.ElementAt(i).ToString(CultureInfo.InvariantCulture));
                        break;
                    }
                    case "WeirdHandThings":
                    {
                        for (int i = 0; i < Bird.Skeleton?.WeirdHandThings?.Count; i++)
                            lstSkeleton.Items.Add(Bird.Skeleton.WeirdHandThings.ElementAt(i).ToString(CultureInfo.InvariantCulture));
                        break;
                    }
                    case "Skull":
                    {
                        for (int i = 0; i < Bird.Skeleton?.Skull?.Count; i++)
                            lstSkeleton.Items.Add(Bird.Skeleton.Skull.ElementAt(i).ToString(CultureInfo.InvariantCulture));
                        break;
                    }
                    case "Teeth":
                    {
                        for (int i = 0; i < Bird.Skeleton?.Teeth?.Count; i++)
                            lstSkeleton.Items.Add(Bird.Skeleton.Teeth.ElementAt(i).ToString(CultureInfo.InvariantCulture));
                        break;
                    }
                    case "Feet":
                    {
                        for (int i = 0; i < Bird.Skeleton?.Feet?.Count; i++)
                            lstSkeleton.Items.Add(Bird.Skeleton.Feet.ElementAt(i).ToString(CultureInfo.InvariantCulture));
                        break;
                    }
                    case "Tail":
                    {
                        for (int i = 0; i < Bird.Skeleton?.Tail?.Count; i++)
                            lstSkeleton.Items.Add(Bird.Skeleton.Tail.ElementAt(i).ToString(CultureInfo.InvariantCulture));
                        break;
                    }
                    case "Spine":
                    {
                        for (int i = 0; i < Bird.Skeleton?.Spine?.Count; i++)
                            lstSkeleton.Items.Add(Bird.Skeleton.Spine.ElementAt(i).ToString(CultureInfo.InvariantCulture));
                        break;
                    }
                }
                lblListHeader.Text = lstSkeleton.Items.Count + @" " + cmbSkeletonType.Text + @" bone on the skeleton.";
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error:" + ex.Message);
            }
        }

        private void txtSkeletonValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }
                if ((e.KeyChar == '.') && (((TextBox) sender).Text.IndexOf('.') > 0))
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error:" + ex.Message);
            }
        }
        #endregion
        #region public methods
        public void BirdFromGrid()
        {
            try
            {
                lblId.Text = Bird.Id.ToString();
                txtHeight.Text = (Bird.Height * CalculateUm()).ToString(CultureInfo.InvariantCulture);
                txtWeight.Text = Bird.Weight.ToString(CultureInfo.InvariantCulture);
                txtLength.Text = (Bird.Length * CalculateUm()).ToString(CultureInfo.InvariantCulture);
                txtGirth.Text = (Bird.Girth * CalculateUm()).ToString(CultureInfo.InvariantCulture);
                txtSpecimenName.Text = Bird.SpecimenName;
                txtAltitude.Text = Bird.Location.Altitude.ToString(CultureInfo.InvariantCulture);
                txtLatitude.Text = Bird.Location.Latitude.ToString(CultureInfo.InvariantCulture);
                txtLongitude.Text = Bird.Location.Longitude.ToString(CultureInfo.InvariantCulture);
                txtName.Text = Bird.Location.Name;
                UpdateSkeletonList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error:" + ex.Message);
            }
        }
        #endregion
    }
}