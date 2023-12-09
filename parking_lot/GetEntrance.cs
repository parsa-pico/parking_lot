using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace parking_lot
{
    public partial class GetEntrance : Form
    {
        DBAccess db = new DBAccess();
        DataTable entrances = new DataTable();
        private string startDate;
        private string endDate;
        public GetEntrance ()
        {
            InitializeComponent();
        }

        private void GetEntrance_Load ( object sender, EventArgs e )
        {
            loadData(null, null);

        }

        private void loadData ( string startDate, string endDate )
        {
            entrances.Clear();
            string query = "select car_plate, concat(s.first_name,' ',s.last_name) as staff_name," +
        " entered_date_time,rfid_tag,exited_date_time,payed_amount " +
        "from entrance e join car c on e.car_id=c.car_id join" +
        " staff s on e.staff_id=s.staff_id";
            string sumQuery = "select sum(payed_amount) from entrance";
            if ( startDate != null && endDate != null )
            {
                query += String.Format(" where entered_date_time between '{0}' and '{1}' ", startDate, endDate);
                sumQuery += String.Format(" where entered_date_time between '{0}' and '{1}' ", startDate, endDate);
            }

            db.readDatathroughAdapter(query, entrances);
            dataGridView1.DataSource = entrances;
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;

            SqlDataReader reader = db.readDatathroughReader(sumQuery);
            reader.Read();
            IDataRecord record = (IDataRecord)reader;

            if ( record.FieldCount > 0 && record[0].GetType().ToString() != "System.DBNull" )
            {


                int sum = (Int32)record[0];
                lblTotalPay.Text = "total payment:" + sum.ToString();
            }
            else
                lblTotalPay.Text = "total payment: 0";
            reader.Close();

        }

        private void dateTimePicker1_ValueChanged ( object sender, EventArgs e )
        {
            string date = dateTimePicker1.Value.ToString("yyyy'-'MM'-'dd");
            startDate = date;
        }

        private void dateTimePicker2_ValueChanged ( object sender, EventArgs e )
        {
            string date = dateTimePicker2.Value.ToString("yyyy'-'MM'-'dd");
            endDate = date;
        }

        private void btnSearch_Click ( object sender, EventArgs e )
        {
            loadData(startDate, endDate);
        }
    }
}
