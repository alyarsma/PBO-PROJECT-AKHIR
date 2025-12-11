using PBO_PROJECT_AKHIR.Controllers;
using PBO_PROJECT_AKHIR.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PBO_PROJECT_AKHIR.Views.Admin
{
    public partial class PesananMasuk : Form
    {
        public PesananMasuk()
        {
            InitializeComponent();
            LoadOrders();
            dataGridPesanan.CellClick += dataGridPesanan_CellClick;
        }

        private void LoadOrders()
        {
            OrderController oc = new OrderController();

            // AMBIL HANYA ORDER PENDING
            var orders = oc.GetAllOrders()
                           .Where(o => o.Status == StatusPesanan.pending)
                           .ToList();

            var tampilkanOrder = new List<object>();

            foreach (var order in orders)
            {
                tampilkanOrder.Add(new
                {
                    order_id = order.OrderId,
                    user_id = order.UserId,
                    tanggal = order.TanggalPesanan,
                    jumlah_item = order.JumlahItem,
                    total = order.Subtotal,
                    status = order.Status.ToString()
                });
            }

            dataGridPesanan.AutoGenerateColumns = true;
            dataGridPesanan.DataSource = tampilkanOrder;
            dataGridPesanan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Tambah tombol aksi selesai
            if (dataGridPesanan.Columns.Contains("btnSelesai"))
                dataGridPesanan.Columns.Remove("btnSelesai");

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = "btnSelesai";
            btn.HeaderText = "Aksi";
            btn.Text = "Selesai";
            btn.UseColumnTextForButtonValue = true;

            dataGridPesanan.Columns.Add(btn);
        }


        private void dataGridPesanan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridPesanan.Columns["btnSelesai"].Index && e.RowIndex >= 0)
            {
                int orderId = Convert.ToInt32(dataGridPesanan.Rows[e.RowIndex].Cells["order_id"].Value);

                var confirm = MessageBox.Show(
                    "Ubah status pesanan ini menjadi SELESAI?",
                    "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                );

                if (confirm == DialogResult.Yes)
                {
                    OrderController oc = new OrderController();
                    if (oc.UpdateOrderStatus(orderId, StatusPesanan.selesai))
                    {
                        MessageBox.Show("Pesanan berhasil diselesaikan!");
                        LoadOrders();
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            BerandaAdmin berandaAdmin = new BerandaAdmin();
            berandaAdmin.FormClosed += (s, args) => this.Close();
            berandaAdmin.Show();
            this.Hide();
        }

        private void btnKatalog_Click(object sender, EventArgs e)
        {
            KatalogAAdmin katalogAAdmin = new KatalogAAdmin(new ProductController());
            katalogAAdmin.FormClosed += (s, args) => this.Close();
            katalogAAdmin.Show();
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
