using Services;
using System;
using System.Linq;
using System.Windows.Forms;
using Domain;
using Services.ViewModel;

namespace Archaeomania
{
    public partial class Archaeomania : Form
    {
        private readonly BirdService _birdService;
        private readonly UnitOfMeasurementService _unitOfMeasurementService;
        internal Enums.UnitOfMeasurement FromUm;
        #region Constructor
        public Archaeomania()
        {
            _birdService = new BirdService();
            _unitOfMeasurementService = new UnitOfMeasurementService();
            FromUm = Enums.UnitOfMeasurement.Milliarchieops;
            InitializeComponent();
        }
        #endregion
        #region Private Methods
        private void Archaeomania_Load(object sender, EventArgs e)
        {
            try
            {
                BindBirds();
                BindUm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error:" + ex.Message);
            }
        }

        private void BindUm()
        {
            try
            {
                cmbUM.DataSource = Enum.GetValues(typeof(Enums.UnitOfMeasurement));
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error:" + ex.Message);
            }
        }

        private void btnAddBird_Click(object sender, EventArgs e)
        {
            BirdDetails detailFrom = new BirdDetails(_birdService, this, _unitOfMeasurementService);
            detailFrom.Show();
        }

        private void btnDeleteBird_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridBirds.CurrentRow == null)
                {
                    MessageBox.Show(@"First select a bird from grid to delete");
                }
                else
                    _birdService.RemoveBird((Bird) gridBirds.CurrentRow?.DataBoundItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            BindBirds();
        }

        private void btnViewBird_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridBirds.CurrentRow == null)
                {
                    MessageBox.Show(@"First select a bird from grid to view");
                }
                else
                {
                    BirdDetails detailFrom = new BirdDetails(_birdService, this, _unitOfMeasurementService)
                    {
                        Bird = (Bird) gridBirds.CurrentRow?.DataBoundItem
                    };
                    detailFrom.BirdFromGrid();
                    detailFrom.Um = cmbUM.SelectedValue as Enums.UnitOfMeasurement? ??
                                    Enums.UnitOfMeasurement.Milliarchieops;
                    detailFrom.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error:" + ex.Message);
            }
        }

        private void cmbUM_SelectedIndexChanged(object sender, EventArgs e)
        {
           BindBirds();
        }
        #endregion
        #region Public Methods
        public void BindBirds()
        {
            try
            {
                gridBirds.AutoGenerateColumns = true;
                Enums.UnitOfMeasurement um = cmbUM.SelectedValue as Enums.UnitOfMeasurement? ?? Enums.UnitOfMeasurement.Milliarchieops;
                gridBirds.DataSource = _birdService.GetBirds(um).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error:" + ex.Message);
            }

        }
        #endregion
    }
}
