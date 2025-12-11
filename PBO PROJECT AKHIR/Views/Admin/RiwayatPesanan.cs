using PBO_PROJECT_AKHIR.Controllers;
using PBO_PROJECT_AKHIR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PBO_PROJECT_AKHIR.Views.Admin
{
    public partial class RiwayatPesanan : Form
    {
        private OrderController orderController = new OrderController();
        private List<Orders> listOrders;

        public RiwayatPesanan()
        {
            InitializeComponent();
            LoadRiwayat();
        }

        private void LoadRiwayat()
        {
            listOrders = orderController.GetAllOrders();

            var tampilkanDetail = new List<object>();

            foreach (var order in listOrders)
            {
                foreach (var item in order.Items)
                {
                    tampilkanDetail.Add(new
                    {
                        order_id = order.OrderId,
                        user_id = order.UserId,
                        tanggal = order.TanggalPesanan,
                        status = order.Status.ToString(),
                        jumlah_item = order.JumlahItem,
                        total_order = order.Subtotal,

                        produk = item.ProductName,
                        harga_satuan = item.Price,
                        qty = item.JumlahItem,
                        subtotal_produk = item.SubTotal
                    });
                }
            }

            dataGridView1.DataSource = tampilkanDetail;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        private void lblPesananMasuk_Click(object sender, EventArgs e)
        {
            PesananMasuk pesananMasuk = new PesananMasuk();
            pesananMasuk.FormClosed += (s, args) => this.Close();
            pesananMasuk.Show();
            this.Hide();
        }

        private void lblRiwayatPesanan_Click(object sender, EventArgs e)
        {
            RiwayatPesanan riwayatPesanan = new RiwayatPesanan();
            riwayatPesanan.FormClosed += (s, args) => this.Close();
            riwayatPesanan.Show();
            this.Hide();
        }
    }
}
