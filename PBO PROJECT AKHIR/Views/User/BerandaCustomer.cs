using PBO_PROJECT_AKHIR.Views.Admin;
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
    public partial class BerandaCustomer : Form
    {
        public BerandaCustomer()
        {
            InitializeComponent();
        }

        private void BerandaCustomer_Load(object sender, EventArgs e)
        {

        }

        private void tbkatalogcustomer_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbkatalog_Click(object sender, EventArgs e)
        {
            KatalogCustomer katalogcustomer = new KatalogCustomer();
            katalogcustomer.FormClosed += (s, args) => this.Close();
            katalogcustomer.Show();
            this.Hide();
        }

        private void pctbProfilUser_Click(object sender, EventArgs e)
        {
            ProfilUser profilUser = new ProfilUser();
            profilUser.FormClosed += (s, args) => this.Close();
            profilUser.Show();
            this.Hide();
        }
    }
}
