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

        private List<OrderItem> _items;

        private OrderController _orderController = new OrderController();


        public DetailPesanan(List<OrderItem> items)
        {
            InitializeComponent();
            _items = items;
            TampilkanProduk();
        }

        private void TampilkanProduk()
        {
            flowLayoutPanelProduk.Controls.Clear();

            foreach (var item in _items)
            {
                Panel baris = new Panel();
                baris.Height = 190;                     
                baris.Width = flowLayoutPanelProduk.Width - 40;
                baris.Margin = new Padding(10);
                baris.BackColor = Color.White;
                baris.BorderStyle = BorderStyle.FixedSingle;

                int colProduk = 30;     
                int colHarga = 520;     
                int colQty = 700;     
                int colTotal = 880;


                PictureBox img = new PictureBox();
                img.Image = item.Image;
                img.SizeMode = PictureBoxSizeMode.Zoom;
                img.Width = 130;                  
                img.Height = 130;
                img.Left = colProduk;
                img.Top = 25;


                Label lblNama = new Label();
                lblNama.Text = item.ProductName;
                lblNama.Font = new Font("Poppins", 12, FontStyle.Bold);   
                lblNama.Left = colProduk + 150;
                lblNama.Top = 75;
                lblNama.Width = 300;


                Label lblHarga = new Label();
                lblHarga.Text = $"Rp {item.Price:n0}";
                lblHarga.Font = new Font("Poppins", 11, FontStyle.Regular);
                lblHarga.Left = colHarga;
                lblHarga.Top = 75;
                lblHarga.Width = 150;

                Label lblQty = new Label();
                lblQty.Text = item.JumlahItem.ToString();
                lblQty.Font = new Font("Poppins", 11, FontStyle.Regular);
                lblQty.Left = colQty;
                lblQty.Top = 75;
                lblQty.Width = 80;

                Label lblTotal = new Label();
                lblTotal.Text = $"Rp {item.SubTotal:n0}";
                lblTotal.Font = new Font("Poppins", 11, FontStyle.Bold);
                lblTotal.Left = colTotal;
                lblTotal.Top = 75;
                lblTotal.Width = 180;

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
            // SIMPAN PESANAN KE DATABASE
            int orderId = _orderController.CreateOrder(_items);

            if (orderId > 0)
            {
                MessageBox.Show(
                    $"Pesanan anda berhasil dibuat!\nID Pesanan: {orderId}\nSilakan ambil pesanan di tempat.",
                    "Pesanan Berhasil!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show(
                    "Terjadi kesalahan saat membuat pesanan.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            // KEMBALI KE KATALOG CUSTOMER
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
