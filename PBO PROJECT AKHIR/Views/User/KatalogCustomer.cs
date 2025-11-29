using PBO_PROJECT_AKHIR.Controllers;
using PBO_PROJECT_AKHIR.Helpers;
using PBO_PROJECT_AKHIR.Interfaces;
using PBO_PROJECT_AKHIR.Models;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PBO_PROJECT_AKHIR.Views.User
{
    public partial class KatalogCustomer : Form
    {
        private IProduk productController;
        private OrderController orderController;
        private Label lblKeranjang;
        private Label lblSubtotal;
        public KatalogCustomer()
        {
            InitializeComponent();
            productController = new ProductController();
            orderController = new OrderController();
            InitializeCartLabels();
            LoadProducts();
        }
        private void InitializeCartLabels()
        {
            // Inisialisasi lblKeranjang
            lblKeranjang = new Label();
            lblKeranjang.Name = "lblKeranjang";
            lblKeranjang.Text = "0";
            lblKeranjang.Font = new Font("Poppins", 11, FontStyle.Bold);
            lblKeranjang.ForeColor = Color.Black;
            lblKeranjang.Size = new Size(248, 25);
            lblKeranjang.Location = new Point(57, 19); // Sesuaikan dengan layout form
            lblKeranjang.TextAlign = ContentAlignment.MiddleLeft;

            // Inisialisasi lblSubtotal
            lblSubtotal = new Label();
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Text = "Rp0";
            lblSubtotal.Font = new Font("Poppins", 11, FontStyle.Bold);
            lblSubtotal.ForeColor = Color.Black;
            lblSubtotal.Size = new Size(114, 25);
            lblSubtotal.Location = new Point(1020, 12); // Sesuaikan dengan layout form
            lblSubtotal.TextAlign = ContentAlignment.MiddleLeft;

            // Tambahkan ke form
            panel3.Controls.Add(lblKeranjang);
            panel3.Controls.Add(lblSubtotal);

            // Atau jika sudah ada di designer, cari kontrol yang sudah ada

        }


        public Panel CreateProductPanel(Product product, Orders order, Label labelKeranjang, Label labelSubtotal)
        {
            int jumlahDipilih = 0;

            Panel panel = new Panel
            {
                Size = new Size(264, 302),
                Margin = new Padding(6),
                BackColor = Color.Transparent,
                BackgroundImage = Properties.Resources.ANGGREK_CATTLEYA,
                BackgroundImageLayout = ImageLayout.Zoom,
            };

            PictureBox displayProduct = new PictureBox
            {
                Location = new Point(37, 10),
                Size = new Size(190, 130),
                BackColor = Color.Transparent,
                SizeMode = PictureBoxSizeMode.Zoom,
            };
            displayProduct.Image = ImageHelper.BinaryToImage(product.Image);

            Label namaProduk = new Label
            {
                Text = product.ProductName,
                Location = new Point(28, 159),
                Size = new Size(192, 28),
                BackColor = Color.Transparent,
                Font = new Font("Poppins", 9, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft
            };

            Label hargaProduk = new Label
            {
                Text = product.Price.ToString(),
                Location = new Point(119, 192),
                Size = new Size(126, 28),
                BackColor = Color.Transparent,
                ForeColor = Color.Purple,
                Font = new Font("Poppins", 9, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft
            };

            Label stokProduk = new Label
            {
                Text = product.Stock.ToString(),
                Location = new Point(20, 194),
                Size = new Size(88, 28),
                BackColor = Color.Transparent,
                ForeColor = Color.DarkGray,
                Font = new Font("Poppins", 8, FontStyle.Regular),
                TextAlign = ContentAlignment.MiddleLeft
            };

            Label jmlhProduk = new Label
            {
                Text = order.JumlahItem.ToString(),
                Location = new Point(120, 246),
                Size = new Size(25, 31),
                BackColor = Color.Transparent,
                Font = new Font("Poppins", 9, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };

            Button buttonTambah = new Button
            {
                Location = new Point(151, 243),
                Size = new Size(26, 33),
                Text = "+",
                BackColor = Color.Transparent,
                Font = new Font("Poppins", 9, FontStyle.Bold)
            };
            buttonTambah.Click += (s, e) =>
            {
                if (product.Stock <= 0)
                {
                    MessageBox.Show("Stok habis!");
                    return;
                }

                jumlahDipilih++;
                product.Stock--;

                // Update UI panel
                jmlhProduk.Text = jumlahDipilih.ToString();
                stokProduk.Text = $"Stok: {product.Stock}";

                // update label keranjang
                int totalKeranjang;
                if (!int.TryParse(labelKeranjang.Text, out totalKeranjang)) totalKeranjang = 0;
                totalKeranjang++;
                labelKeranjang.Text = totalKeranjang.ToString();

                // update subtotal
                int subtotal;
                if (!int.TryParse(labelSubtotal.Text, out subtotal)) subtotal = 0;
                subtotal += product.Price;
                labelSubtotal.Text = subtotal.ToString();
            };


            Button buttonKurang = new Button
            {
                Location = new Point(86, 243),
                Size = new Size(26, 33),
                Text = "-",
                BackColor = Color.Transparent,
                Font = new Font("Poppins", 9, FontStyle.Bold)
            };

            buttonKurang.Click += (s, e) =>
            {
                if (jumlahDipilih <= 0)
                    return;

                jumlahDipilih--;
                product.Stock++;

                // Update UI panel
                jmlhProduk.Text = jumlahDipilih.ToString();
                stokProduk.Text = $"Stok: {product.Stock}";

                // Update label keranjang
                int totalKeranjang;
                if (!int.TryParse(labelKeranjang.Text, out totalKeranjang)) totalKeranjang = 0;
                totalKeranjang--;
                labelKeranjang.Text = totalKeranjang <= 0 ? "Tidak ada produk yang dipilih" : totalKeranjang.ToString();

                // Update subtotal
                int subtotal;
                if (!int.TryParse(labelSubtotal.Text, out subtotal)) subtotal = 0;
                subtotal -= product.Price;
                if (subtotal < 0) subtotal = 0; // supaya subtotal tidak negatif
                labelSubtotal.Text = subtotal.ToString();
            };

            // tambahkan controls ke panel produk
            panel.Controls.Add(displayProduct);
            panel.Controls.Add(namaProduk);
            panel.Controls.Add(hargaProduk);
            panel.Controls.Add(stokProduk);
            panel.Controls.Add(jmlhProduk);
            panel.Controls.Add(buttonTambah);
            panel.Controls.Add(buttonKurang);

            return panel;
        }

        public void LoadProducts()
{
    flowLayoutPanel1.Controls.Clear();

    List<Product> products = productController.GetAllProduct();

    foreach (Product product in products)
    {
        // Jika belum ada order untuk user saat ini, bisa bikin dummy atau ambil order dari controller
        Orders order = orderController.GetCurrentOrder(); // contoh, ganti sesuai implementasimu

        Panel panelProduk = CreateProductPanel(product, order, lblKeranjang, lblSubtotal);
        flowLayoutPanel1.Controls.Add(panelProduk);
    }
}


        private void label2_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void KatalogCustomer_Load(object sender, EventArgs e) { }
    }
}
