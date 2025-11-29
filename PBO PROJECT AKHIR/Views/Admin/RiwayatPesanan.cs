using PBO_PROJECT_AKHIR.Database;
using PBO_PROJECT_AKHIR.Models;
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
    public partial class RiwayatPesanan : Form
    {
        private DbTransaksi db = new DbTransaksi();
        private List<transaksi> listTransaksi;

        public RiwayatPesanan()
        {
            InitializeComponent();
            LoadRiwayat();
        }

        private void LoadRiwayat()
        {
            listTransaksi = db.GetAllTransaksi();

            dataGridView1.DataSource = listTransaksi.Select(x => new
            {
                x.transaksi_id,
                x.user_id,
                x.tanggal_transaksi,
                x.total_harga,
                TotalItem = x.DetailTransaksiList.Sum(d => d.jumlah_item)
            }).ToList();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Ambil ID transaksi dari grid utama
            int trxID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["transaksi_id"].Value);

            // Ambil objek transaksi dari list
            var trx = listTransaksi.FirstOrDefault(x => x.transaksi_id == trxID);

            if (trx == null)
            {
                MessageBox.Show("Data transaksi tidak ditemukan.");
                return;
            }

            // Tampilkan detail ke datagrid detail
            dataGridView1.DataSource = trx.DetailTransaksiList.Select(d => new
            {
                Produk = d.product_name,
                Jumlah = d.jumlah_item,
                Harga = d.price,
                Subtotal = d.jumlah_item * d.price
            }).ToList();
        }
    }
}
