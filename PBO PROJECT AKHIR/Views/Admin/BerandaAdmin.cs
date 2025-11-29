using PBO_PROJECT_AKHIR.Controllers;
using PBO_PROJECT_AKHIR.Interfaces;
using PBO_PROJECT_AKHIR.Views.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBO_PROJECT_AKHIR.Views.Admin
{
    public partial class BerandaAdmin : Form
    {
        private readonly IProduk productInterface;
        public BerandaAdmin()
        {
            InitializeComponent();
            productInterface = new ProductController();
        }

        private void BerandaAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btntransaksiadmin_Click(object sender, EventArgs e) //kena pencet
        {
            TransaksiAdm transaksiAdm = new TransaksiAdm();
            transaksiAdm.FormClosed += (s, args) => this.Close();
            transaksiAdm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e) //button keuangan, kena pencet Allahuakbar
        {

        }

        private void btnkatalogadmin_Click(object sender, EventArgs e)
        {
            KatalogAAdmin katalogAdmin = new KatalogAAdmin(productInterface);
            katalogAdmin.FormClosed += (s, args) => this.Close();
            katalogAdmin.Show();
            this.Hide();
        }
    }
}
