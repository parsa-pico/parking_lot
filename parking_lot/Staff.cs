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
    public partial class Staff : Form
    {
        DBAccess db = new DBAccess();
        public Staff ()
        {
            InitializeComponent();
        }

        private void Staff_Load ( object sender, EventArgs e )
        {
            // TODO: This line of code loads data into the 'parking_lotDataSet.job_position' table. You can move, or remove it, as needed.
            this.job_positionTableAdapter.Fill(this.parking_lotDataSet.job_position);
            // TODO: This line of code loads data into the 'parking_lotDataSet.staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter1.Fill(this.parking_lotDataSet.staff);
            // TODO: This line of code loads data into the 'parking_lotDataSet1.staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.parking_lotDataSet1.staff);

        }

        private void btnSave_Click ( object sender, EventArgs e )
        {
            db.executeDataAdapter(parking_lotDataSet.staff, "select * from staff");
        }
    }
}
