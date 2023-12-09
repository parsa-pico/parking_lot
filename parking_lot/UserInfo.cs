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
    public partial class UserInfo : Form
    {
        DBAccess db = new DBAccess();
        public UserInfo ()
        {
            InitializeComponent();
        }

        private void UserInfo_Load ( object sender, EventArgs e )
        {

            textBoxEmail.Text = Login.email;
            textBoxPass.Text = Login.password;
            textBoxFirstName.Text = Login.firstName;
            textBoxLastName.Text = Login.lastName;


        }

        private void btnUpdate_Click ( object sender, EventArgs e )
        {
            string email = textBoxEmail.Text;
            string password = textBoxPass.Text;
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            string staffId = Login.id;

            if ( email == "" || password == "" || firstName == "" || lastName == "" )
                MessageBox.Show("please fill out all of the form");
            else
            {
                SqlCommand cmd = new SqlCommand("update staff set" +
                    " email= @email ,password=@password,first_name=@firstName,last_name=@lastName" +
                    " where staff_id=@id");
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@firstName", firstName);
                cmd.Parameters.AddWithValue("@lastName", lastName);
                cmd.Parameters.AddWithValue("@id", staffId);


                int result = db.executeQuery(cmd);
                if ( result == 0 )
                {
                    MessageBox.Show("error happend");
                }
                else
                {
                    MessageBox.Show("account details updated,you need to login again");
                    this.Hide();
                    Login l = new Login();
                    l.Show();
                }
            }
        }
    }
}
