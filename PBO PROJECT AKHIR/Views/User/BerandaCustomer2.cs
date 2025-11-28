using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBO_PROJECT_AKHIR.Views.User
{
    public partial class BerandaCustomer2 : Form
    {
        public BerandaCustomer2()
        {
            InitializeComponent();
        }

        private void pbprofilecustomer_Click(object sender, EventArgs e)
        {

        }

        private void btnberandacustomer_Click(object sender, EventArgs e)
        {

        }

        private void btnkatalogcustomer_Click(object sender, EventArgs e)
        {
            KatalogCustomer2 userView = new KatalogCustomer2();
            userView.FormClosed += (s, args) => this.Close();
            userView.Show();
            this.Hide();
        }

        private void btntransaksicustomer_Click(object sender, EventArgs e)
        {

        }
    }
}
