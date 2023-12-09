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
    public partial class SignUp : Form
    {
        DBAccess db = new DBAccess();
        public SignUp ()
        {
            InitializeComponent();
        }

        private void btnSignup_Click ( object sender, EventArgs e )
        {
            string email = textBoxEmail.Text;
            string password = textBoxPass.Text;
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            int jobPositionId = comboBoxJobPosition.SelectedIndex;

            if ( email == "" || password == "" || firstName == "" || lastName == "" || jobPositionId == -1 )
                MessageBox.Show("please fill out all of the form");
            else
            {
                SqlCommand cmd = new SqlCommand("insert into " +
                    "staff(email,password,first_name,last_name,job_position)" +
                    " values(@email,@password,@firstName,@lastName,@jobPosition)");
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@firstName", firstName);
                cmd.Parameters.AddWithValue("@lastName", lastName);
                cmd.Parameters.AddWithValue("@jobPosition", jobPositionId);

                int result = db.executeQuery(cmd);
                if ( result == 0 )
                {
                    MessageBox.Show("error happend");
                }
                else
                {
                    DataTable user = new DataTable();
                    user.Columns.Add("first_name");
                    user.Columns.Add("last_name");
                    user.Columns.Add("job_position");
                    user.Rows.Add(firstName, lastName, jobPositionId);
                    MessageBox.Show("user added");

                }
            }
        }
    }
}
