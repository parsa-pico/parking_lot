using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parking_lot
{
    public partial class Exit : Form
    {
        DBAccess db = new DBAccess();
        Dictionary<string, string> entrance =
            new Dictionary<string, string>(){
                {"id", null},
                {"paymentAmount", null},
                {"parkingSpaceId",null }
            };


        public Exit ()
        {
            InitializeComponent();
            groupBox1.Visible = false;
        }

        private void btnFind_Click ( object sender, EventArgs e )
        {

            string rfidTag = textBoxRfid.Text;
            object foundEntrance = findEntrance(rfidTag);
            if ( foundEntrance == null )
                MessageBox.Show("no entrance found");
            else
            {
                DataRow row = (DataRow)foundEntrance;
                int paymentAmount = computePaymentAmount(row["entered_date_time"].ToString());

                entrance["id"] = row["entrance_id"].ToString();
                entrance["paymentAmount"] = paymentAmount.ToString();
                entrance["parkingSpaceId"] = row["parking_space_id"].ToString();

                lblCarPlateValue.Text = row["car_plate"].ToString();
                lblEnteredDateTimeValue.Text = row["entered_date_time"].ToString();
                lblPayAmount.Text = paymentAmount.ToString();
                groupBox1.Visible = true;

                //after payment fill null values
                //set parking space to un occupied
            }

        }

        private object findEntrance ( string rfidTag )
        {
            string query = "select * from entrance e" +
                " join car c on e.car_id = c.car_id" +
                " where rfid_tag = '" + rfidTag + "'" +
                " and exited_date_time is null";
            DataTable result = new DataTable();
            db.readDatathroughAdapter(query, result);
            if ( result.Rows.Count == 0 )
                return null;
            else return result.Rows[0];
        }
        private int computePaymentAmount ( string startDate )
        {

            int hourDiff = dateDiff("hour", startDate);
            DataTable tariff = getTariffs();
            lblhours.Text = hourDiff > 0 ? hourDiff.ToString() : (hourDiff + 1).ToString();
            if ( hourDiff > 24 )
            {
                DataRow[] row = tariff.Select("type = 'day'");
                int amount = Int32.Parse(row[0]["amount"].ToString());
                return amount * hourDiff;
            }
            else
            {

                DataRow[] row = tariff.Select("type= 'hour'");
                int amount = Int32.Parse(row[0]["amount"].ToString());
                if ( hourDiff == 0 )
                {
                    return amount * (hourDiff + 1);
                }
                else
                    return amount * hourDiff;
            }
        }
        private int dateDiff ( string diffType, string startDate, string endDate = "getdate()" )
        {

            string query = String.Format("select datediff ({0},'{1}',{2}) as diff",
                diffType, startDate, endDate);

            DataTable result = new DataTable();
            db.readDatathroughAdapter(query, result);
            return Int32.Parse(result.Rows[0]["diff"].ToString());

        }
        private DataTable getTariffs ()
        {
            string query = "select * from tariff";
            DataTable result = new DataTable();
            db.readDatathroughAdapter(query, result);
            return result;
        }

        private void setEntranceToPayed ( string id, string paymentAmount )
        {
            string query = String.Format("update entrance" +
                " set payed_amount={0}," +
                "exited_date_time=getdate()," +
                "payed_date_time=getdate()" +
                "where entrance_id={1}"
                , paymentAmount, id);
            SqlCommand cmd = new SqlCommand(query);
            db.executeQuery(cmd);

        }
        private void unOccupyParkingSpace ( string id )
        {
            string query = String.Format("update parking_space" +
               " set is_occupied=0" +
               "where parking_space_id={0}"
               , id);
            SqlCommand cmd = new SqlCommand(query);
            db.executeQuery(cmd);
        }
        private void button1_Click ( object sender, EventArgs e )
        {

            DialogResult dr = MessageBox.Show(
                  "Are you sure you want to submit exit?\n (this mean customer has payed)",
                  "alert", MessageBoxButtons.YesNo
                  );
            if ( dr == DialogResult.Yes )
            {
                setEntranceToPayed(entrance["id"], entrance["paymentAmount"]);
                unOccupyParkingSpace(entrance["parkingSpaceId"]);
                MessageBox.Show("added exit");
                groupBox1.Visible = false;
                textBoxRfid.Text = "";

            }

        }

        private void label5_Click ( object sender, EventArgs e )
        {

        }
    }
}
