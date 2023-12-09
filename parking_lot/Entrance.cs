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
    public partial class Entrance : Form
    {
        DBAccess db = new DBAccess();
        public Entrance ()
        {
            InitializeComponent();
        }

        private void button1_Click ( object sender, EventArgs e )
        {
            string staffId = Login.id;

            string carPlate = textBoxCarPlate.Text;
            string rfid = textBoxRfid.Text;

            object foundCar = findCar(carPlate);
            int carId = -1;
            string parkingSpaceId;

            if ( foundCar == null )
                carId = insertCar(carPlate);
            else
            {
                DataTable carDt = (DataTable)foundCar;
                carId = Int32.Parse(carDt.Rows[0]["car_id"].ToString());
            }
            DataTable parkingSpace = findParkingSpace();
            if ( parkingSpace.Rows.Count == 0 )
            {
                MessageBox.Show("all parking spaces are occupied");

            }
            else
            {
                parkingSpaceId = parkingSpace.Rows[0]["parking_space_id"].ToString();
                insertEntrance(staffId, carId.ToString(), parkingSpaceId, rfid);
                occupyParkingSpace(parkingSpaceId);
                string floor = parkingSpace.Rows[0]["floor"].ToString();
                string section = parkingSpace.Rows[0]["section"].ToString();
                string number = parkingSpace.Rows[0]["number"].ToString();
                string messageBoxCaption = "added entrance \n parking space details: \n" +
                    " floor: " + floor +
                    "\nsection: " + section +
                    "\nnumber: " + number;
                MessageBox.Show(messageBoxCaption);
            }



        }
        private int insertEntrance ( string staff_id,
                                    string car_id,
                                    string parking_space_id,
                                    string rfid_tag )
        {
            string insertQuery = "insert into entrance" +
                "(entered_date_time,staff_id,car_id,parking_space_id,rfid_tag)" +
                " values(getdate(),@staff_id,@car_id,@parking_space_id,@rfid_tag)";
            SqlCommand cmd = new SqlCommand(insertQuery);
            cmd.Parameters.AddWithValue("@staff_id", staff_id);
            cmd.Parameters.AddWithValue("@car_id", car_id);
            cmd.Parameters.AddWithValue("@parking_space_id", parking_space_id);
            cmd.Parameters.AddWithValue("@rfid_tag", rfid_tag);
            try
            {

                return db.executeQuery(cmd);
            }
            catch ( Exception e )
            {
                throw e;
            }
        }
        private void occupyParkingSpace ( string parkingSpaceId )
        {

            string query = "update parking_space" +
                " set is_occupied=1 where" +
                " parking_space_id='" + parkingSpaceId + "'";
            SqlCommand cmd = new SqlCommand(query);
            db.executeQuery(cmd);

        }
        private DataTable findParkingSpace ()
        {
            string query = "select top 1 * from parking_space where is_occupied=0 ";
            DataTable result = new DataTable();
            db.readDatathroughAdapter(query, result);
            return result;
        }
        private int insertCar ( string carPlate )
        {
            SqlCommand cmd = new SqlCommand("insert into car(car_plate) values(@car_plate)");
            cmd.Parameters.AddWithValue("car_plate", carPlate);
            int id = db.executeQueyWithInsertedId(cmd);
            return id;
        }

        private object findCar ( string carPlate )
        {
            string query = "select * from car where  car_plate= '" + carPlate + "'";
            DataTable result = new DataTable();
            db.readDatathroughAdapter(query, result);
            if ( result.Rows.Count == 0 )
            {
                return null;
            }
            else
            {
                return result;
            }

        }
    }
}
