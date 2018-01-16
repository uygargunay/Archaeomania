namespace Archaeomania
{
    partial class Archaeomania
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Archaeomania));
            this.btnAddBird = new System.Windows.Forms.Button();
            this.btnViewBird = new System.Windows.Forms.Button();
            this.btnDeleteBird = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gridBirds = new System.Windows.Forms.DataGridView();
            this.specimenNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birdTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wingspanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.girthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birdBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbUM = new System.Windows.Forms.ComboBox();
            this.lblUM = new System.Windows.Forms.Label();
            this.birdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBirds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birdBindingSource1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.birdBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddBird
            // 
            this.btnAddBird.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddBird.Location = new System.Drawing.Point(971, 9);
            this.btnAddBird.Name = "btnAddBird";
            this.btnAddBird.Size = new System.Drawing.Size(125, 32);
            this.btnAddBird.TabIndex = 2;
            this.btnAddBird.Text = "Add New Bird";
            this.btnAddBird.UseVisualStyleBackColor = true;
            this.btnAddBird.Click += new System.EventHandler(this.btnAddBird_Click);
            // 
            // btnViewBird
            // 
            this.btnViewBird.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnViewBird.Location = new System.Drawing.Point(1228, 9);
            this.btnViewBird.Name = "btnViewBird";
            this.btnViewBird.Size = new System.Drawing.Size(114, 32);
            this.btnViewBird.TabIndex = 3;
            this.btnViewBird.Text = "View Bird Details";
            this.btnViewBird.UseVisualStyleBackColor = true;
            this.btnViewBird.Click += new System.EventHandler(this.btnViewBird_Click);
            // 
            // btnDeleteBird
            // 
            this.btnDeleteBird.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDeleteBird.Location = new System.Drawing.Point(1102, 9);
            this.btnDeleteBird.Name = "btnDeleteBird";
            this.btnDeleteBird.Size = new System.Drawing.Size(120, 32);
            this.btnDeleteBird.TabIndex = 4;
            this.btnDeleteBird.Text = "Delete Bird";
            this.btnDeleteBird.UseVisualStyleBackColor = true;
            this.btnDeleteBird.Click += new System.EventHandler(this.btnDeleteBird_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gridBirds, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1351, 620);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // gridBirds
            // 
            this.gridBirds.AllowUserToAddRows = false;
            this.gridBirds.AllowUserToDeleteRows = false;
            this.gridBirds.AutoGenerateColumns = false;
            this.gridBirds.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridBirds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBirds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.specimenNameDataGridViewTextBoxColumn,
            this.birdTypeDataGridViewTextBoxColumn,
            this.wingspanDataGridViewTextBoxColumn,
            this.heightDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.lengthDataGridViewTextBoxColumn,
            this.girthDataGridViewTextBoxColumn});
            this.gridBirds.DataSource = this.birdBindingSource1;
            this.gridBirds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridBirds.Location = new System.Drawing.Point(3, 3);
            this.gridBirds.MultiSelect = false;
            this.gridBirds.Name = "gridBirds";
            this.gridBirds.ReadOnly = true;
            this.gridBirds.RowTemplate.Height = 24;
            this.gridBirds.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridBirds.Size = new System.Drawing.Size(1345, 564);
            this.gridBirds.TabIndex = 1;
            // 
            // specimenNameDataGridViewTextBoxColumn
            // 
            this.specimenNameDataGridViewTextBoxColumn.DataPropertyName = "SpecimenName";
            this.specimenNameDataGridViewTextBoxColumn.HeaderText = "SpecimenName";
            this.specimenNameDataGridViewTextBoxColumn.Name = "specimenNameDataGridViewTextBoxColumn";
            this.specimenNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birdTypeDataGridViewTextBoxColumn
            // 
            this.birdTypeDataGridViewTextBoxColumn.DataPropertyName = "BirdType";
            this.birdTypeDataGridViewTextBoxColumn.HeaderText = "BirdType";
            this.birdTypeDataGridViewTextBoxColumn.Name = "birdTypeDataGridViewTextBoxColumn";
            this.birdTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wingspanDataGridViewTextBoxColumn
            // 
            this.wingspanDataGridViewTextBoxColumn.DataPropertyName = "Wingspan";
            this.wingspanDataGridViewTextBoxColumn.HeaderText = "Wingspan";
            this.wingspanDataGridViewTextBoxColumn.Name = "wingspanDataGridViewTextBoxColumn";
            this.wingspanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // heightDataGridViewTextBoxColumn
            // 
            this.heightDataGridViewTextBoxColumn.DataPropertyName = "Height";
            this.heightDataGridViewTextBoxColumn.HeaderText = "Height";
            this.heightDataGridViewTextBoxColumn.Name = "heightDataGridViewTextBoxColumn";
            this.heightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Weight";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            this.weightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lengthDataGridViewTextBoxColumn
            // 
            this.lengthDataGridViewTextBoxColumn.DataPropertyName = "Length";
            this.lengthDataGridViewTextBoxColumn.HeaderText = "Length";
            this.lengthDataGridViewTextBoxColumn.Name = "lengthDataGridViewTextBoxColumn";
            this.lengthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // girthDataGridViewTextBoxColumn
            // 
            this.girthDataGridViewTextBoxColumn.DataPropertyName = "Girth";
            this.girthDataGridViewTextBoxColumn.HeaderText = "Girth";
            this.girthDataGridViewTextBoxColumn.Name = "girthDataGridViewTextBoxColumn";
            this.girthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birdBindingSource1
            // 
            this.birdBindingSource1.DataSource = typeof(Services.ViewModel.Bird);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.Controls.Add(this.btnAddBird, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnViewBird, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnDeleteBird, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmbUM, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblUM, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 573);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1345, 44);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // cmbUM
            // 
            this.cmbUM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbUM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUM.FormattingEnabled = true;
            this.cmbUM.Location = new System.Drawing.Point(157, 3);
            this.cmbUM.Name = "cmbUM";
            this.cmbUM.Size = new System.Drawing.Size(194, 24);
            this.cmbUM.TabIndex = 35;
            this.cmbUM.SelectedIndexChanged += new System.EventHandler(this.cmbUM_SelectedIndexChanged);
            // 
            // lblUM
            // 
            this.lblUM.AutoSize = true;
            this.lblUM.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUM.Location = new System.Drawing.Point(3, 6);
            this.lblUM.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblUM.Name = "lblUM";
            this.lblUM.Size = new System.Drawing.Size(148, 17);
            this.lblUM.TabIndex = 34;
            this.lblUM.Text = "Unit of Measurement:";
            this.lblUM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // birdBindingSource
            // 
            this.birdBindingSource.DataSource = typeof(Services.ViewModel.Bird);
            // 
            // Archaeomania
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 620);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Archaeomania";
            this.Text = "Archaeomania";
            this.Load += new System.EventHandler(this.Archaeomania_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridBirds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birdBindingSource1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.birdBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddBird;
        private System.Windows.Forms.BindingSource birdBindingSource;
        private System.Windows.Forms.Button btnViewBird;
        private System.Windows.Forms.Button btnDeleteBird;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView gridBirds;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblUM;
        private System.Windows.Forms.ComboBox cmbUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn specimenNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birdTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wingspanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn girthDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource birdBindingSource1;
    }
}

