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
    public partial class buttonHomePage : UserControl
    {
        public buttonHomePage ()
        {
            InitializeComponent();
        }

        private void button1_Click ( object sender, EventArgs e )
        {
            this.ParentForm.Hide();
            Home h = new Home();
            h.Show();
        }
    }
}
