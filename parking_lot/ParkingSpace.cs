using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace parking_lot
{
    public partial class ParkingSpace : Form
    {
        DBAccess db = new DBAccess();
        public ParkingSpace ()
        {
            InitializeComponent();
        }


        private void ParkingSpace_Load ( object sender, EventArgs e )
        {
            // TODO: This line of code loads data into the 'parking_lotDataSet1.parking_space' table. You can move, or remove it, as needed.
            parking_lotDataSet1.parking_space.Columns["is_occupied"].DefaultValue = 0;
            this.parking_spaceTableAdapter.Fill(this.parking_lotDataSet1.parking_space);


        }

        private void btnSubmit_Click ( object sender, EventArgs e )
        {
            string query = "select * from parking_space";
            DataTable grid = parking_lotDataSet1.parking_space;

            db.executeDataAdapter(grid, query);
        }

        private void dataGridView1_DefaultValuesNeeded ( object sender, DataGridViewRowEventArgs e )
        {
            // Console.WriteLine(e.Row.Cells.ToString());
            //Console.WriteLine(e.Row.Cells);
            // Console.WriteLine(e.Row.Cells["floor"]);

            // e.Row.Cells["is_occupied"].Value = 0;
        }
    }
}
