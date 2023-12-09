
namespace parking_lot
{
    partial class ParkingSpace
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
            this.parkingspaceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.parking_lotDataSet1 = new parking_lot.parking_lotDataSet1();
            this.parkingspaceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSubmit = new System.Windows.Forms.Button();
            this.parking_spaceTableAdapter = new parking_lot.parking_lotDataSet1TableAdapters.parking_spaceTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.parkingspaceBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.buttonHomePage1 = new parking_lot.buttonHomePage();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isoccupiedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.parkingspaceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parking_lotDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingspaceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingspaceBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // parkingspaceBindingSource1
            // 
            this.parkingspaceBindingSource1.DataMember = "parking_space";
            this.parkingspaceBindingSource1.DataSource = this.parking_lotDataSet1;
            // 
            // parking_lotDataSet1
            // 
            this.parking_lotDataSet1.DataSetName = "parking_lotDataSet1";
            this.parking_lotDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(335, 393);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(131, 23);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "submit changes";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // parking_spaceTableAdapter
            // 
            this.parking_spaceTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.isoccupiedDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.parkingspaceBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(144, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 308);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_DefaultValuesNeeded);
            // 
            // parkingspaceBindingSource2
            // 
            this.parkingspaceBindingSource2.DataMember = "parking_space";
            this.parkingspaceBindingSource2.DataSource = this.parking_lotDataSet1;
            // 
            // buttonHomePage1
            // 
            this.buttonHomePage1.Location = new System.Drawing.Point(25, 37);
            this.buttonHomePage1.Name = "buttonHomePage1";
            this.buttonHomePage1.Size = new System.Drawing.Size(80, 31);
            this.buttonHomePage1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "parking spaces";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "floor";
            this.dataGridViewTextBoxColumn2.HeaderText = "floor";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "section";
            this.dataGridViewTextBoxColumn3.HeaderText = "section";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "number";
            this.dataGridViewTextBoxColumn4.HeaderText = "number";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // isoccupiedDataGridViewCheckBoxColumn
            // 
            this.isoccupiedDataGridViewCheckBoxColumn.DataPropertyName = "is_occupied";
            this.isoccupiedDataGridViewCheckBoxColumn.FalseValue = "0";
            this.isoccupiedDataGridViewCheckBoxColumn.HeaderText = "is_occupied";
            this.isoccupiedDataGridViewCheckBoxColumn.IndeterminateValue = "0";
            this.isoccupiedDataGridViewCheckBoxColumn.Name = "isoccupiedDataGridViewCheckBoxColumn";
            this.isoccupiedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isoccupiedDataGridViewCheckBoxColumn.TrueValue = "1";
            // 
            // ParkingSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.buttonHomePage1);
            this.Name = "ParkingSpace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ParkingSpace";
            this.Load += new System.EventHandler(this.ParkingSpace_Load);
            ((System.ComponentModel.ISupportInitialize)(this.parkingspaceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parking_lotDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingspaceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingspaceBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private buttonHomePage buttonHomePage1;

        private System.Windows.Forms.BindingSource parkingspaceBindingSource;

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridViewTextBoxColumn parkingspaceidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn floorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private parking_lotDataSet1 parking_lotDataSet1;
        private System.Windows.Forms.BindingSource parkingspaceBindingSource1;
        private parking_lotDataSet1TableAdapters.parking_spaceTableAdapter parking_spaceTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource parkingspaceBindingSource2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isoccupiedDataGridViewCheckBoxColumn;
    }
}