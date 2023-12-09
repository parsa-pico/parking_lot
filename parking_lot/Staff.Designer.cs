
namespace parking_lot
{
    partial class Staff
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
        {
            if ( disposing && (components != null) )
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
        private void InitializeComponent ()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.jobpositionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parking_lotDataSet = new parking_lot.parking_lotDataSet();
            this.staffBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.parking_lotDataSet1 = new parking_lot.parking_lotDataSet1();
            this.parkinglotDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffTableAdapter = new parking_lot.parking_lotDataSet1TableAdapters.staffTableAdapter();
            this.staffTableAdapter1 = new parking_lot.parking_lotDataSetTableAdapters.staffTableAdapter();
            this.staffBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.job_positionTableAdapter = new parking_lot.parking_lotDataSetTableAdapters.job_positionTableAdapter();
            this.buttonHomePage1 = new parking_lot.buttonHomePage();
            this.btnSave = new System.Windows.Forms.Button();
            this.staffidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobpositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobpositionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parking_lotDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parking_lotDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkinglotDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(319, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "staff";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffidDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.jobpositionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.staffBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(63, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 368);
            this.dataGridView1.TabIndex = 2;
            // 
            // jobpositionBindingSource
            // 
            this.jobpositionBindingSource.DataMember = "job_position";
            this.jobpositionBindingSource.DataSource = this.parking_lotDataSet;
            // 
            // parking_lotDataSet
            // 
            this.parking_lotDataSet.DataSetName = "parking_lotDataSet";
            this.parking_lotDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffBindingSource1
            // 
            this.staffBindingSource1.DataMember = "staff";
            this.staffBindingSource1.DataSource = this.parking_lotDataSet;
            // 
            // parking_lotDataSet1
            // 
            this.parking_lotDataSet1.DataSetName = "parking_lotDataSet1";
            this.parking_lotDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // parkinglotDataSet1BindingSource
            // 
            this.parkinglotDataSet1BindingSource.DataSource = this.parking_lotDataSet1;
            this.parkinglotDataSet1BindingSource.Position = 0;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "staff";
            this.staffBindingSource.DataSource = this.parkinglotDataSet1BindingSource;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // staffTableAdapter1
            // 
            this.staffTableAdapter1.ClearBeforeFill = true;
            // 
            // staffBindingSource2
            // 
            this.staffBindingSource2.DataMember = "staff";
            this.staffBindingSource2.DataSource = this.parking_lotDataSet;
            // 
            // job_positionTableAdapter
            // 
            this.job_positionTableAdapter.ClearBeforeFill = true;
            // 
            // buttonHomePage1
            // 
            this.buttonHomePage1.Location = new System.Drawing.Point(28, 39);
            this.buttonHomePage1.Name = "buttonHomePage1";
            this.buttonHomePage1.Size = new System.Drawing.Size(80, 31);
            this.buttonHomePage1.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(315, 504);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(156, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // staffidDataGridViewTextBoxColumn
            // 
            this.staffidDataGridViewTextBoxColumn.DataPropertyName = "staff_id";
            this.staffidDataGridViewTextBoxColumn.HeaderText = "staff_id";
            this.staffidDataGridViewTextBoxColumn.Name = "staffidDataGridViewTextBoxColumn";
            this.staffidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "first_name";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "last_name";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jobpositionDataGridViewTextBoxColumn
            // 
            this.jobpositionDataGridViewTextBoxColumn.DataPropertyName = "job_position";
            this.jobpositionDataGridViewTextBoxColumn.DataSource = this.jobpositionBindingSource;
            this.jobpositionDataGridViewTextBoxColumn.DisplayMember = "name";
            this.jobpositionDataGridViewTextBoxColumn.DisplayStyleForCurrentCellOnly = true;
            this.jobpositionDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jobpositionDataGridViewTextBoxColumn.HeaderText = "job_position";
            this.jobpositionDataGridViewTextBoxColumn.Name = "jobpositionDataGridViewTextBoxColumn";
            this.jobpositionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.jobpositionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.jobpositionDataGridViewTextBoxColumn.ValueMember = "job_position_id";
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 567);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonHomePage1);
            this.Name = "Staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.Staff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobpositionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parking_lotDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parking_lotDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkinglotDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private buttonHomePage buttonHomePage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource parkinglotDataSet1BindingSource;
        private parking_lotDataSet1 parking_lotDataSet1;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private parking_lotDataSet1TableAdapters.staffTableAdapter staffTableAdapter;
        private parking_lotDataSet parking_lotDataSet;
        private System.Windows.Forms.BindingSource staffBindingSource1;
        private parking_lotDataSetTableAdapters.staffTableAdapter staffTableAdapter1;
        private System.Windows.Forms.BindingSource staffBindingSource2;
        private System.Windows.Forms.BindingSource jobpositionBindingSource;
        private parking_lotDataSetTableAdapters.job_positionTableAdapter job_positionTableAdapter;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn jobpositionDataGridViewTextBoxColumn;
    }
}