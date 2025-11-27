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
            KatalogCustomer userView = new KatalogCustomer();
            userView.FormClosed += (s, args) => this.Close();
            userView.Show();
            this.Hide();
        }
    }
}
