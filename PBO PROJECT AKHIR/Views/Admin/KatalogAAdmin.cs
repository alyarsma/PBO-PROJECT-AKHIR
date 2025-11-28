using PBO_PROJECT_AKHIR.Helpers;
using PBO_PROJECT_AKHIR.Interfaces;
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
    public partial class KatalogAAdmin : Form
    {
        private IProduk productController;

        public KatalogAAdmin(IProduk productInterface)
        {
            InitializeComponent();
            productController = productInterface;
            LoadProducts();
        }

        private void label1_Click(object sender, EventArgs e) //ini harga produk, kena pencet 2 kali. keinget figma wokwok
        {

        }

        public Panel CreateProductPanel(Product product)
        {
            Panel panelproduk = new Panel
            {
                Size = new Size(252, 326),
                //Location = new Point(3,3),
                Margin = new Padding(3, 3, 3, 3),
                BackColor = Color.Transparent,
                BackgroundImage = Properties.Resources.card_produk,
                BackgroundImageLayout = ImageLayout.Zoom,
            };

            PictureBox displayProduk = new PictureBox
            {
                Location = new Point(26, 27),
                Size = new Size(200, 150),
                BackColor = Color.Transparent,
                SizeMode = PictureBoxSizeMode.Zoom
            };
            displayProduk.Image = ImageHelper.BinaryToImage(product.Image);

            Label namaProduk = new Label
            {
                Text = product.ProductName,
                Location = new Point(26, 186),
                Size = new Size(190, 50),
                BackColor = Color.Transparent,
                ForeColor = Color.Indigo,
                Font = new Font("Poppins SemiBold", 10, FontStyle.Bold),
                TextAlign = ContentAlignment.TopLeft
            };

            Label hargaProduk = new Label
            {
                Text = "Rp " + product.Price.ToString("N0"),
                Location = new Point(95, 238),
                Size = new Size(131, 30),
                BackColor = Color.Transparent,
                ForeColor = Color.Indigo,
                Font = new Font("Poppins SemiBold", 10, FontStyle.Bold),
                TextAlign = ContentAlignment.TopLeft
            };

            Label Stok = new Label
            {
                Text = "Stok : ",
                Location = new Point(26, 268),
                Size = new Size(59, 30),
                BackColor = Color.Transparent,
                ForeColor = Color.SlateBlue,
                Font = new Font("Poppins SemiBold", 10, FontStyle.Bold),
                TextAlign = ContentAlignment.TopLeft
            };

            Label stokProduk = new Label
            {
                Text = product.Stock.ToString(),
                Location = new Point(82, 268),
                Size = new Size(50, 30),
                BackColor = Color.Transparent,
                ForeColor = Color.SlateBlue,
                Font = new Font("Poppins SemiBold", 10, FontStyle.Bold),
                TextAlign = ContentAlignment.TopLeft
            };

            Button editProduk = new Button
            {
                Location = new Point(191, 267),
                Size = new Size(35, 29),
                BackColor = Color.Transparent,
                BackgroundImage = Properties.Resources.mingcute__pencil_line1,
                BackgroundImageLayout = ImageLayout.Zoom
            };
            //editProduk.Click += (sender, e) => productController.EditProduk();

            //PictureBox editProduk = new PictureBox
            //{
            //    Location = new Point(191, 268),
            //    Size = new Size(35, 29),
            //    BackColor = Color.Transparent,
            //    SizeMode = PictureBoxSizeMode.Zoom
            //};
            ////editProduk.Click += (sender, e) => productController.EditProduk();

            panelproduk.Controls.Add(displayProduk);
            panelproduk.Controls.Add(namaProduk);
            panelproduk.Controls.Add(hargaProduk);
            panelproduk.Controls.Add(Stok);
            panelproduk.Controls.Add(stokProduk);
            panelproduk.Controls.Add(editProduk);

            return panelproduk;
        }

        public void LoadProducts()
        {
            flowLayoutPanelprodukadmin.Controls.Clear();

            List<Product> products = productController.GetAllProduct();

            foreach (Product product in products)
            {
                Panel panelProduk = CreateProductPanel(product);
                flowLayoutPanelprodukadmin.Controls.Add(panelProduk);
            }
        }

        private void btntambahproduk_Click(object sender, EventArgs e)
        {
            TambahProduk tambahProduk = new TambahProduk();
            tambahProduk.Show();
        }

        private void btnberandaadmin_Click(object sender, EventArgs e)
        {
            BerandaAdmin berandaAdmin = new BerandaAdmin();
            berandaAdmin.FormClosed += (s, args) => this.Close();
            berandaAdmin.Show();
            this.Hide();
        }
    }
}
