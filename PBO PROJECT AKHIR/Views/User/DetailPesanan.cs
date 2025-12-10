using PBO_PROJECT_AKHIR.Controllers;
using PBO_PROJECT_AKHIR.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PBO_PROJECT_AKHIR.Views.User
{
    public partial class DetailPesanan : Form
    {
        // =============== FIELD ==================
        private List<OrderItem> _items;

        // =============== CONSTRUCTOR ===============
        public DetailPesanan(List<OrderItem> items)
        {
            InitializeComponent();
            _items = items;
            TampilkanProduk();
        }

        // =============== TAMPILKAN PRODUK ===============
        private void TampilkanProduk()
        {
            flowLayoutPanelProduk.Controls.Clear();

            foreach (var item in _items)
            {
                Panel baris = new Panel();
                baris.Height = 190;                     // diperbesar
                baris.Width = flowLayoutPanelProduk.Width - 40;
                baris.Margin = new Padding(10);
                baris.BackColor = Color.White;
                baris.BorderStyle = BorderStyle.FixedSingle;

                int colProduk = 30;     // lokasi gambar + nama
                int colHarga = 520;     // sejajar dengan "Harga Satuan"
                int colQty = 700;     // sejajar dengan "Kuantitas"
                int colTotal = 880;

                // ==== GAMBAR PRODUK ====
                PictureBox img = new PictureBox();
                img.Image = item.Image;
                img.SizeMode = PictureBoxSizeMode.Zoom;
                img.Width = 130;                  // diperbesar
                img.Height = 130;
                img.Left = colProduk;
                img.Top = 25;

                // ==== NAMA PRODUK ====
                Label lblNama = new Label();
                lblNama.Text = item.ProductName;
                lblNama.Font = new Font("Poppins", 12, FontStyle.Bold);   // font diperbesar
                lblNama.Left = colProduk + 150;
                lblNama.Top = 75;
                lblNama.Width = 300;

                // ==== HARGA SATUAN ====
                Label lblHarga = new Label();
                lblHarga.Text = $"Rp {item.Price:n0}";
                lblHarga.Font = new Font("Poppins", 11, FontStyle.Regular);
                lblHarga.Left = colHarga;
                lblHarga.Top = 75;
                lblHarga.Width = 150;

                // ==== KUANTITAS ====
                Label lblQty = new Label();
                lblQty.Text = item.JumlahItem.ToString();
                lblQty.Font = new Font("Poppins", 11, FontStyle.Regular);
                lblQty.Left = colQty;
                lblQty.Top = 75;
                lblQty.Width = 80;

                // ==== TOTAL HARGA ====
                Label lblTotal = new Label();
                lblTotal.Text = $"Rp {item.SubTotal:n0}";
                lblTotal.Font = new Font("Poppins", 11, FontStyle.Bold);
                lblTotal.Left = colTotal;
                lblTotal.Top = 75;
                lblTotal.Width = 180;

                // ADD CONTROLS
                baris.Controls.Add(img);
                baris.Controls.Add(lblNama);
                baris.Controls.Add(lblHarga);
                baris.Controls.Add(lblQty);
                baris.Controls.Add(lblTotal);

                flowLayoutPanelProduk.Controls.Add(baris);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
            "Pesanan anda telah dibuat,\nharap datang ke tempat untuk mengambil pesanan anda.",
            "Pesanan Berhasil!",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
    );

            // Kembali ke katalog customer
            KatalogCustomer katalog = new KatalogCustomer();
            katalog.Show();
            this.Close();
        }

        private void btnbatal_Click(object sender, EventArgs e)
        {
            KatalogCustomer katalog = new KatalogCustomer();
            katalog.Show();
            this.Close();
        }
    }
}
