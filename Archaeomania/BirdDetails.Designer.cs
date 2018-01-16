namespace Archaeomania
{
    partial class BirdDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BirdDetails));
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtGirth = new System.Windows.Forms.TextBox();
            this.txtSpecimenName = new System.Windows.Forms.TextBox();
            this.txtLatitude = new System.Windows.Forms.TextBox();
            this.txtLongitude = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAltitude = new System.Windows.Forms.TextBox();
            this.btnUpdateBird = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.grpSkeleton = new System.Windows.Forms.GroupBox();
            this.lstSkeleton = new System.Windows.Forms.ListView();
            this.btnAddSkeleton = new System.Windows.Forms.Button();
            this.lblSkeletonLength = new System.Windows.Forms.Label();
            this.cmbSkeletonType = new System.Windows.Forms.ComboBox();
            this.lblWings = new System.Windows.Forms.Label();
            this.txtSkeletonValue = new System.Windows.Forms.TextBox();
            this.grpLocation = new System.Windows.Forms.GroupBox();
            this.lblAltitude = new System.Windows.Forms.Label();
            this.lblLongitude = new System.Windows.Forms.Label();
            this.lblLatitude = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSpecimenName = new System.Windows.Forms.Label();
            this.lblGirth = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblUM = new System.Windows.Forms.Label();
            this.cmbUM = new System.Windows.Forms.ComboBox();
            this.skeletonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.birdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblListHeader = new System.Windows.Forms.Label();
            this.grpDetails.SuspendLayout();
            this.grpSkeleton.SuspendLayout();
            this.grpLocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skeletonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birdBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(82, 59);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(50, 22);
            this.txtHeight.TabIndex = 1;
            this.txtHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSkeletonValue_KeyPress);
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(225, 62);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(50, 22);
            this.txtWeight.TabIndex = 2;
            this.txtWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSkeletonValue_KeyPress);
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(506, 64);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(50, 22);
            this.txtLength.TabIndex = 4;
            this.txtLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSkeletonValue_KeyPress);
            // 
            // txtGirth
            // 
            this.txtGirth.Location = new System.Drawing.Point(363, 62);
            this.txtGirth.Name = "txtGirth";
            this.txtGirth.Size = new System.Drawing.Size(50, 22);
            this.txtGirth.TabIndex = 3;
            this.txtGirth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSkeletonValue_KeyPress);
            // 
            // txtSpecimenName
            // 
            this.txtSpecimenName.Location = new System.Drawing.Point(143, 25);
            this.txtSpecimenName.Name = "txtSpecimenName";
            this.txtSpecimenName.Size = new System.Drawing.Size(270, 22);
            this.txtSpecimenName.TabIndex = 0;
            // 
            // txtLatitude
            // 
            this.txtLatitude.Location = new System.Drawing.Point(309, 28);
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.Size = new System.Drawing.Size(236, 22);
            this.txtLatitude.TabIndex = 8;
            // 
            // txtLongitude
            // 
            this.txtLongitude.Location = new System.Drawing.Point(81, 53);
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.Size = new System.Drawing.Size(158, 22);
            this.txtLongitude.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(81, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(158, 22);
            this.txtName.TabIndex = 7;
            // 
            // txtAltitude
            // 
            this.txtAltitude.Location = new System.Drawing.Point(309, 57);
            this.txtAltitude.Name = "txtAltitude";
            this.txtAltitude.Size = new System.Drawing.Size(236, 22);
            this.txtAltitude.TabIndex = 10;
            // 
            // btnUpdateBird
            // 
            this.btnUpdateBird.Location = new System.Drawing.Point(492, 413);
            this.btnUpdateBird.Name = "btnUpdateBird";
            this.btnUpdateBird.Size = new System.Drawing.Size(95, 33);
            this.btnUpdateBird.TabIndex = 32;
            this.btnUpdateBird.Text = "Save Bird";
            this.btnUpdateBird.UseVisualStyleBackColor = true;
            this.btnUpdateBird.Click += new System.EventHandler(this.btnUpdateBird_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 514);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 17);
            this.lblId.TabIndex = 20;
            this.lblId.Visible = false;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(22, 59);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(53, 17);
            this.lblHeight.TabIndex = 21;
            this.lblHeight.Text = "Height:";
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.grpSkeleton);
            this.grpDetails.Controls.Add(this.grpLocation);
            this.grpDetails.Controls.Add(this.lblSpecimenName);
            this.grpDetails.Controls.Add(this.lblGirth);
            this.grpDetails.Controls.Add(this.lblLength);
            this.grpDetails.Controls.Add(this.txtSpecimenName);
            this.grpDetails.Controls.Add(this.lblWeight);
            this.grpDetails.Controls.Add(this.lblHeight);
            this.grpDetails.Controls.Add(this.txtGirth);
            this.grpDetails.Controls.Add(this.txtHeight);
            this.grpDetails.Controls.Add(this.txtWeight);
            this.grpDetails.Controls.Add(this.txtLength);
            this.grpDetails.Location = new System.Drawing.Point(12, 12);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(575, 398);
            this.grpDetails.TabIndex = 22;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Bird Details";
            // 
            // grpSkeleton
            // 
            this.grpSkeleton.Controls.Add(this.lblListHeader);
            this.grpSkeleton.Controls.Add(this.lstSkeleton);
            this.grpSkeleton.Controls.Add(this.btnAddSkeleton);
            this.grpSkeleton.Controls.Add(this.lblSkeletonLength);
            this.grpSkeleton.Controls.Add(this.cmbSkeletonType);
            this.grpSkeleton.Controls.Add(this.lblWings);
            this.grpSkeleton.Controls.Add(this.txtSkeletonValue);
            this.grpSkeleton.Location = new System.Drawing.Point(12, 200);
            this.grpSkeleton.Name = "grpSkeleton";
            this.grpSkeleton.Size = new System.Drawing.Size(551, 189);
            this.grpSkeleton.TabIndex = 28;
            this.grpSkeleton.TabStop = false;
            this.grpSkeleton.Text = "Skeleton";
            // 
            // lstSkeleton
            // 
            this.lstSkeleton.FullRowSelect = true;
            this.lstSkeleton.GridLines = true;
            this.lstSkeleton.Location = new System.Drawing.Point(183, 41);
            this.lstSkeleton.Name = "lstSkeleton";
            this.lstSkeleton.Size = new System.Drawing.Size(361, 122);
            this.lstSkeleton.TabIndex = 30;
            this.lstSkeleton.UseCompatibleStateImageBehavior = false;
            this.lstSkeleton.View = System.Windows.Forms.View.List;
            // 
            // btnAddSkeleton
            // 
            this.btnAddSkeleton.Location = new System.Drawing.Point(29, 130);
            this.btnAddSkeleton.Name = "btnAddSkeleton";
            this.btnAddSkeleton.Size = new System.Drawing.Size(95, 33);
            this.btnAddSkeleton.TabIndex = 13;
            this.btnAddSkeleton.Text = "Add ";
            this.btnAddSkeleton.UseVisualStyleBackColor = true;
            this.btnAddSkeleton.Click += new System.EventHandler(this.btnAddSkeleton_Click);
            // 
            // lblSkeletonLength
            // 
            this.lblSkeletonLength.AutoSize = true;
            this.lblSkeletonLength.Location = new System.Drawing.Point(-1, 70);
            this.lblSkeletonLength.Name = "lblSkeletonLength";
            this.lblSkeletonLength.Size = new System.Drawing.Size(93, 17);
            this.lblSkeletonLength.TabIndex = 29;
            this.lblSkeletonLength.Text = "Bone Length:";
            this.lblSkeletonLength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbSkeletonType
            // 
            this.cmbSkeletonType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSkeletonType.FormattingEnabled = true;
            this.cmbSkeletonType.Items.AddRange(new object[] {
            "Wings",
            "WeirdHandThings",
            "Skull",
            "Teeth",
            "Feet",
            "Tail",
            "Spine"});
            this.cmbSkeletonType.Location = new System.Drawing.Point(4, 41);
            this.cmbSkeletonType.Name = "cmbSkeletonType";
            this.cmbSkeletonType.Size = new System.Drawing.Size(173, 24);
            this.cmbSkeletonType.TabIndex = 11;
            this.cmbSkeletonType.SelectedIndexChanged += new System.EventHandler(this.cmbSkeletonType_SelectedIndexChanged);
            // 
            // lblWings
            // 
            this.lblWings.AutoSize = true;
            this.lblWings.Location = new System.Drawing.Point(3, 21);
            this.lblWings.Name = "lblWings";
            this.lblWings.Size = new System.Drawing.Size(81, 17);
            this.lblWings.TabIndex = 26;
            this.lblWings.Text = "Bone Type:";
            this.lblWings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSkeletonValue
            // 
            this.txtSkeletonValue.Location = new System.Drawing.Point(5, 90);
            this.txtSkeletonValue.Name = "txtSkeletonValue";
            this.txtSkeletonValue.Size = new System.Drawing.Size(171, 22);
            this.txtSkeletonValue.TabIndex = 12;
            this.txtSkeletonValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSkeletonValue_KeyPress);
            // 
            // grpLocation
            // 
            this.grpLocation.Controls.Add(this.lblAltitude);
            this.grpLocation.Controls.Add(this.lblLongitude);
            this.grpLocation.Controls.Add(this.lblLatitude);
            this.grpLocation.Controls.Add(this.lblName);
            this.grpLocation.Controls.Add(this.txtName);
            this.grpLocation.Controls.Add(this.txtLatitude);
            this.grpLocation.Controls.Add(this.txtLongitude);
            this.grpLocation.Controls.Add(this.txtAltitude);
            this.grpLocation.Location = new System.Drawing.Point(18, 94);
            this.grpLocation.Name = "grpLocation";
            this.grpLocation.Size = new System.Drawing.Size(551, 100);
            this.grpLocation.TabIndex = 27;
            this.grpLocation.TabStop = false;
            this.grpLocation.Text = "Location";
            // 
            // lblAltitude
            // 
            this.lblAltitude.AutoSize = true;
            this.lblAltitude.Location = new System.Drawing.Point(244, 57);
            this.lblAltitude.Name = "lblAltitude";
            this.lblAltitude.Size = new System.Drawing.Size(59, 17);
            this.lblAltitude.TabIndex = 28;
            this.lblAltitude.Text = "Altitude:";
            this.lblAltitude.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLongitude
            // 
            this.lblLongitude.AutoSize = true;
            this.lblLongitude.Location = new System.Drawing.Point(0, 56);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(75, 17);
            this.lblLongitude.TabIndex = 27;
            this.lblLongitude.Text = "Longitude:";
            this.lblLongitude.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLatitude
            // 
            this.lblLatitude.AutoSize = true;
            this.lblLatitude.Location = new System.Drawing.Point(245, 28);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(63, 17);
            this.lblLatitude.TabIndex = 26;
            this.lblLatitude.Text = "Latitude:";
            this.lblLatitude.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(26, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 25;
            this.lblName.Text = "Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSpecimenName
            // 
            this.lblSpecimenName.AutoSize = true;
            this.lblSpecimenName.Location = new System.Drawing.Point(22, 28);
            this.lblSpecimenName.Name = "lblSpecimenName";
            this.lblSpecimenName.Size = new System.Drawing.Size(115, 17);
            this.lblSpecimenName.TabIndex = 26;
            this.lblSpecimenName.Text = "Specimen Name:";
            // 
            // lblGirth
            // 
            this.lblGirth.AutoSize = true;
            this.lblGirth.Location = new System.Drawing.Point(314, 62);
            this.lblGirth.Name = "lblGirth";
            this.lblGirth.Size = new System.Drawing.Size(43, 17);
            this.lblGirth.TabIndex = 24;
            this.lblGirth.Text = "Girth:";
            this.lblGirth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(444, 67);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(56, 17);
            this.lblLength.TabIndex = 23;
            this.lblLength.Text = "Length:";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(163, 62);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(56, 17);
            this.lblWeight.TabIndex = 22;
            this.lblWeight.Text = "Weight:";
            // 
            // lblUM
            // 
            this.lblUM.AutoSize = true;
            this.lblUM.Location = new System.Drawing.Point(21, 421);
            this.lblUM.Name = "lblUM";
            this.lblUM.Size = new System.Drawing.Size(143, 17);
            this.lblUM.TabIndex = 32;
            this.lblUM.Text = "Unit of Measurement:";
            this.lblUM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbUM
            // 
            this.cmbUM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUM.FormattingEnabled = true;
            this.cmbUM.Location = new System.Drawing.Point(176, 418);
            this.cmbUM.Name = "cmbUM";
            this.cmbUM.Size = new System.Drawing.Size(130, 24);
            this.cmbUM.TabIndex = 31;
            this.cmbUM.SelectedIndexChanged += new System.EventHandler(this.cmbUm_SelectedIndexChanged);
            // 
            // skeletonBindingSource
            // 
            this.skeletonBindingSource.DataSource = typeof(Services.ViewModel.Skeleton);
            // 
            // birdBindingSource
            // 
            this.birdBindingSource.DataSource = typeof(Services.ViewModel.Bird);
            // 
            // lblListHeader
            // 
            this.lblListHeader.AutoSize = true;
            this.lblListHeader.Location = new System.Drawing.Point(182, 18);
            this.lblListHeader.Name = "lblListHeader";
            this.lblListHeader.Size = new System.Drawing.Size(0, 17);
            this.lblListHeader.TabIndex = 31;
            this.lblListHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BirdDetails
            // 
            this.AcceptButton = this.btnUpdateBird;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 452);
            this.Controls.Add(this.lblUM);
            this.Controls.Add(this.cmbUM);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnUpdateBird);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BirdDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BirdDetails";
            this.Load += new System.EventHandler(this.BirdDetails_Load);
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.grpSkeleton.ResumeLayout(false);
            this.grpSkeleton.PerformLayout();
            this.grpLocation.ResumeLayout(false);
            this.grpLocation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skeletonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birdBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtGirth;
        private System.Windows.Forms.TextBox txtSpecimenName;
        private System.Windows.Forms.TextBox txtLatitude;
        private System.Windows.Forms.TextBox txtLongitude;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAltitude;
        private System.Windows.Forms.Button btnUpdateBird;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.GroupBox grpSkeleton;
        private System.Windows.Forms.Label lblWings;
        private System.Windows.Forms.GroupBox grpLocation;
        private System.Windows.Forms.Label lblAltitude;
        private System.Windows.Forms.Label lblLongitude;
        private System.Windows.Forms.Label lblLatitude;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSpecimenName;
        private System.Windows.Forms.Label lblGirth;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblUM;
        private System.Windows.Forms.ComboBox cmbUM;
        private System.Windows.Forms.BindingSource birdBindingSource;
        private System.Windows.Forms.ComboBox cmbSkeletonType;
        private System.Windows.Forms.BindingSource skeletonBindingSource;
        private System.Windows.Forms.Button btnAddSkeleton;
        private System.Windows.Forms.Label lblSkeletonLength;
        private System.Windows.Forms.TextBox txtSkeletonValue;
        private System.Windows.Forms.ListView lstSkeleton;
        private System.Windows.Forms.Label lblListHeader;
    }
}