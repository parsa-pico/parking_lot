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
    public partial class Login : Form
    {

        DBAccess db = new DBAccess();
        public static string id, email, password, firstName, lastName, jobPostionId;

        public Login ()
        {
            InitializeComponent();
        }

        private void btnSignup_Click ( object sender, EventArgs e )
        {
            string emailInput = textBoxEmail.Text;
            string passwordInput = textBoxPass.Text;
            if ( emailInput == "" || passwordInput == "" )
            {
                MessageBox.Show("please fill out the form");
                return;
            }

            DataTable user = new DataTable();
            string query = "select * from staff where email = '" + emailInput + "'";
            db.readDatathroughAdapter(query, user);
            if ( user.Rows.Count == 0 )
            {
                MessageBox.Show("invalid user name");
                return;
            }

            string truePass = user.Rows[0]["password"].ToString();
            if ( passwordInput != truePass )
            {
                MessageBox.Show("invalid password");
                return;
            }

            id = user.Rows[0]["staff_id"].ToString();
            email = user.Rows[0]["email"].ToString();
            password = user.Rows[0]["password"].ToString();
            firstName = user.Rows[0]["first_name"].ToString();
            lastName = user.Rows[0]["last_name"].ToString();
            jobPostionId = user.Rows[0]["job_position"].ToString();

            if ( Int32.Parse(jobPostionId) == 3 )
            {
                MessageBox.Show("you don't have premission to login");
                return;
            };

            this.Hide();
            Home h = new Home();
            h.Show();







        }
    }
}
