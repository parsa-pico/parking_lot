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
    public partial class Home : Form
    {

        public Home ()
        {
            InitializeComponent();

        }

        private void button2_Click ( object sender, EventArgs e )
        {
            this.Hide();
            ParkingSpace ps = new ParkingSpace();
            ps.Show();
        }

        private void Home_Load ( object sender, EventArgs e )
        {
            lblUserFullName.Text = Login.firstName + " "
                + Login.lastName.ToString();
            int positionId = Int32.Parse(Login.jobPostionId);
            string position = getPosition(positionId);
            lblJobPosition.Text = position;
            showMenu(positionId);

        }

        private void showMenu ( int id )
        {
            Point location = new Point(25, 29);

            switch ( id )
            {
                case 0:
                    groupBoxOwner.Visible = true;
                    groupBoxOwner.Location = location;
                    break;
                case 1:
                    groupBoxGuard.Visible = true;
                    groupBoxGuard.Location = location;
                    break;
                case 2:
                    groupBoxPatrol.Visible = true;
                    groupBoxPatrol.Location = location;
                    break;


            }
        }
        private string getPosition ( int positionId )
        {
            if ( positionId == 0 )
                return "owner";
            else if ( positionId == 1 )
                return "guard";
            else if ( positionId == 2 )
                return "patrol";
            else
                return "unknown";
        }

        private void button3_Click ( object sender, EventArgs e )
        {
            this.Hide();
            UserInfo u = new UserInfo();
            u.Show();
        }

        private void button1_Click ( object sender, EventArgs e )
        {
            this.Hide();
            Entrance en = new Entrance();
            en.Show();
        }

        private void button4_Click ( object sender, EventArgs e )
        {
            this.Hide();
            Exit myExit = new Exit();
            myExit.Show();
        }

        private void btnGetEntrance_Click ( object sender, EventArgs e )
        {
            this.Hide();
            GetEntrance ge = new GetEntrance();
            ge.Show();
        }

        private void button5_Click ( object sender, EventArgs e )
        {
            this.Hide();
            new Tariff().Show();
        }

        private void button6_Click ( object sender, EventArgs e )
        {
            this.Hide();
            new Staff().Show();
        }

        private void button7_Click ( object sender, EventArgs e )
        {
            this.Hide();
            new SignUp().Show();
        }

        private void button9_Click ( object sender, EventArgs e )
        {
            this.Close();
            new Login().Show();
        }
    }
}
