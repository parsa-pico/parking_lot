using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parking_lot
{
    public partial class Tariff : Form
    {
        DataTable tariff = new DataTable();
        DBAccess db = new DBAccess();
        public Tariff ()
        {
            InitializeComponent();
            string query = "select * from tariff";
            db.readDatathroughAdapter(query, tariff);
            comboBoxTariffType.DataSource = tariff;
            comboBoxTariffType.DisplayMember = "type";
        }

        private void Tariff_Load ( object sender, EventArgs e )
        {

        }

        private void comboBoxTariffType_SelectedIndexChanged ( object sender, EventArgs e )
        {
            int index = comboBoxTariffType.SelectedIndex;
            textBoxAmount.Text = tariff.Rows[index]["amount"].ToString();
        }

        private void button1_Click ( object sender, EventArgs e )
        {
            int index = comboBoxTariffType.SelectedIndex;
            tariff.Rows[index]["amount"] = textBoxAmount.Text;
            db.executeDataAdapter(tariff, "select * from tariff");
            timer1.Enabled = true;
            lblSaved.Visible = true;


        }

        private void timer1_Tick ( object sender, EventArgs e )
        {

            lblSaved.Visible = false;
            timer1.Enabled = false;
        }
    }
}
