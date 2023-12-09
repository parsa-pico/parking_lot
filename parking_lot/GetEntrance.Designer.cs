
namespace parking_lot
{
    partial class GetEntrance
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.parking_lotDataSet1 = new parking_lot.parking_lotDataSet1();
            this.parking_lotDataSet11 = new parking_lot.parking_lotDataSet1();
            this.parkinglotDataSet11BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.entranceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.entranceTableAdapter = new parking_lot.parking_lotDataSet1TableAdapters.entranceTableAdapter();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carTableAdapter = new parking_lot.parking_lotDataSet1TableAdapters.carTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalPay = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.buttonHomePage1 = new parking_lot.buttonHomePage();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parking_lotDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parking_lotDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkinglotDataSet11BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entranceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(305, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(597, 342);
            this.dataGridView1.TabIndex = 1;
            // 
            // parking_lotDataSet1
            // 
            this.parking_lotDataSet1.DataSetName = "parking_lotDataSet";
            this.parking_lotDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // parking_lotDataSet11
            // 
            this.parking_lotDataSet11.DataSetName = "parking_lotDataSet1";
            this.parking_lotDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // parkinglotDataSet11BindingSource
            // 
            this.parkinglotDataSet11BindingSource.DataSource = this.parking_lotDataSet11;
            this.parkinglotDataSet11BindingSource.Position = 0;
            // 
            // entranceBindingSource
            // 
            this.entranceBindingSource.DataMember = "entrance";
            this.entranceBindingSource.DataSource = this.parkinglotDataSet11BindingSource;
            // 
            // entranceTableAdapter
            // 
            this.entranceTableAdapter.ClearBeforeFill = true;
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataMember = "car";
            this.carBindingSource.DataSource = this.parkinglotDataSet11BindingSource;
            // 
            // carTableAdapter
            // 
            this.carTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(476, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "ENTRANCES";
            // 
            // lblTotalPay
            // 
            this.lblTotalPay.AutoSize = true;
            this.lblTotalPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTotalPay.Location = new System.Drawing.Point(300, 489);
            this.lblTotalPay.Name = "lblTotalPay";
            this.lblTotalPay.Size = new System.Drawing.Size(147, 25);
            this.lblTotalPay.TabIndex = 3;
            this.lblTotalPay.Text = "total payment:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(63, 153);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(196, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Value = new System.DateTime(2022, 2, 1, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(63, 215);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(196, 20);
            this.dateTimePicker2.TabIndex = 4;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "entered start date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "entered end date";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(117, 263);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // buttonHomePage1
            // 
            this.buttonHomePage1.Location = new System.Drawing.Point(25, 33);
            this.buttonHomePage1.Name = "buttonHomePage1";
            this.buttonHomePage1.Size = new System.Drawing.Size(80, 31);
            this.buttonHomePage1.TabIndex = 0;
            // 
            // GetEntrance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 596);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblTotalPay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonHomePage1);
            this.Name = "GetEntrance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GetEntrance";
            this.Load += new System.EventHandler(this.GetEntrance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parking_lotDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parking_lotDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkinglotDataSet11BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entranceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private buttonHomePage buttonHomePage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private parking_lotDataSet1 parking_lotDataSet1;
        private System.Windows.Forms.BindingSource parkinglotDataSet11BindingSource;
        private parking_lotDataSet1 parking_lotDataSet11;
        private System.Windows.Forms.BindingSource entranceBindingSource;
        private parking_lotDataSet1TableAdapters.entranceTableAdapter entranceTableAdapter;
        private System.Windows.Forms.BindingSource carBindingSource;
        private parking_lotDataSet1TableAdapters.carTableAdapter carTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalPay;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearch;
    }
}