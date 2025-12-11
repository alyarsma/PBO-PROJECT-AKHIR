using PBO_PROJECT_AKHIR.Controllers;
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
    public partial class TransaksiAdm : Form
    {
        public TransaksiAdm()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbRiwayatPesanan_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {

        }

        private void btnRiwayat_Click(object sender, EventArgs e)
        {
            RiwayatPesanan riwayatPesanan = new RiwayatPesanan();
            riwayatPesanan.FormClosed += (s, args) => this.Close();
            riwayatPesanan.Show();
            this.Hide();
        }

        private void btnPesanan_Click(object sender, EventArgs e)
        {
            PesananMasuk pesananMasuk = new PesananMasuk();
            pesananMasuk.FormClosed += (s, args) => this.Close();
            pesananMasuk.Show();
            this.Hide();
        }

        private void btnKatalog_Click(object sender, EventArgs e)
        {
            KatalogAAdmin katalogAAdmin = new KatalogAAdmin(new ProductController());
            katalogAAdmin.FormClosed += (s, args) => this.Close();
            katalogAAdmin.Show();
            this.Hide();
        }

        private void btnBeranda_Click(object sender, EventArgs e)
        {
            BerandaAdmin berandaAdmin = new BerandaAdmin();
            berandaAdmin.FormClosed += (s, args) => this.Close();
            berandaAdmin.Show();
            this.Hide();
        }
    }
}
