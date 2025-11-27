using PBO_PROJECT_AKHIR.Controllers;
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
        // controllers
        private CartController cartController = new CartController();
        private ProductController productController = new ProductController();

        // single (global) panel & labels untuk keranjang (dipakai seluruh form)
        private Panel panelKeranjang;
        private Label lblInfo;
        private Label lblTotal;

        public KatalogCustomer()
        {
            InitializeComponent();

            // bikin UI panel keranjang yang satu kali saja
            InitCartUI();

            // load produk ke flowLayoutPanel1 (pastikan ada FlowLayoutPanel bernama flowLayoutPanel1 di Designer)
            LoadProducts();

            // update awal UI keranjang
            UpdateCartUI();
        }

        // --------------------
        // Inisialisasi panel keranjang (hanya 1)
        // --------------------
        private void InitCartUI()
        {
            panelKeranjang = new Panel
            {
                Size = new Size(1729, 134),
                Location = new Point(0, this.ClientSize.Height - 140), // posisi di bawah, sesuaikan kalau perlu
                Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom,
                BackColor = Color.Transparent,
                BackgroundImage = Properties.Resources.banner_bawah__1_,
                BackgroundImageLayout = ImageLayout.Zoom
            };

            lblInfo = new Label
            {
                Text = "Tidak ada produk dipilih",
                Location = new Point(20, 20),
                Size = new Size(500, 30),
                BackColor = Color.Transparent,
                Font = new Font("Poppins", 9, FontStyle.Bold),
                AutoSize = false
            };

            lblTotal = new Label
            {
                Text = "Rp 0",
                Location = new Point(panelKeranjang.Width - 220, 20),
                Size = new Size(200, 30),
                Anchor = AnchorStyles.Right,
                BackColor = Color.Transparent,
                Font = new Font("Poppins", 9, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleRight
            };

            panelKeranjang.Controls.Add(lblInfo);
            panelKeranjang.Controls.Add(lblTotal);

            // pastikan panel di atas control lain (atau sesuaikan)
            this.Controls.Add(panelKeranjang);
            panelKeranjang.BringToFront();
        }

        // --------------------
        // Load produk dari controller -> tampilkan card di flowLayoutPanel1
        // --------------------
        private void LoadProducts()
        {
            // pastikan ada FlowLayoutPanel bernama flowLayoutPanel1 di Designer
            if (this.flowLayoutPanel1 == null) return;

            flowLayoutPanel1.Controls.Clear();

            var products = productController.GetAllProduct();
            if (products == null) return;

            foreach (var p in products)
            {
                Panel card = CreateProductPanel(p);
                flowLayoutPanel1.Controls.Add(card);
            }
        }

        // --------------------
        // Update tampilan isi keranjang (dipanggil setiap kali cart berubah)
        // --------------------
        private void UpdateCartUI()
        {
            if (panelKeranjang == null) return;

            // jangan hapus lblInfo & lblTotal yang sudah ada, kita rebuild isi list saja:
            // cara sederhana: simpan posisi awal, clear then add Info/Total kembali
            panelKeranjang.Controls.Clear();
            panelKeranjang.Controls.Add(lblInfo);
            panelKeranjang.Controls.Add(lblTotal);

            int y = 60; // posisi awal item list di panel keranjang
            foreach (var item in cartController.Cart)
            {
                Label l = new Label
                {
                    Text = $"{item.jumlah_item}x  {item.Product.ProductName} - Rp {item.Product.Price * item.jumlah_item:N0}",
                    Location = new Point(10, y),
                    Width = panelKeranjang.Width - 40,
                    AutoSize = false,
                    Font = new Font("Segoe UI", 10),
                };

                panelKeranjang.Controls.Add(l);
                y += 24;
            }

            // Update Info & Total
            if (cartController.Cart.Count == 0)
                lblInfo.Text = "Tidak ada produk yang dipilih";
            else
                lblInfo.Text = $"{cartController.Cart.Count} produk dipilih";

            lblTotal.Text = $"Rp {cartController.GetTotal():N0}";
        }

        // --------------------
        // Buat card produk (dipanggil per product)
        // --------------------
        public Panel CreateProductPanel(Product product)
        {
            Panel panel = new Panel
            {
                Size = new Size(264, 302),
                Margin = new Padding(6),
                BackColor = Color.WhiteSmoke,
                BorderStyle = BorderStyle.None,
            };

            PictureBox displayProduct = new PictureBox
            {
                Location = new Point(37, 10),
                Size = new Size(190, 130),
                BackColor = Color.Transparent,
                SizeMode = PictureBoxSizeMode.Zoom,
            };

            // kalau product.Image berupa byte[] -> konversi
            if (product.Image != null)
            {
                try
                {
                    if (product.Image is byte[] bytes)
                    {
                        using (var ms = new MemoryStream(bytes))
                        {
                            displayProduct.Image = Image.FromStream(ms);
                        }
                    }
                    else 
                    {
                        displayProduct.Image = null;
                    }
                }
                catch
                {
                    displayProduct.Image = null;
                }
            }

            Label namaProduk = new Label
            {
                Text = product.ProductName,
                Location = new Point(10, 150),
                Size = new Size(240, 28),
                BackColor = Color.Transparent,
                Font = new Font("Poppins", 9, FontStyle.Bold),
                AutoEllipsis = true
            };

            Label hargaProduk = new Label
            {
                Text = $"Rp {product.Price:N0}",
                Location = new Point(10, 180),
                Size = new Size(240, 24),
                BackColor = Color.Transparent,
                ForeColor = Color.Purple,
                Font = new Font("Poppins", 9, FontStyle.Bold)
            };

            Label stokProduk = new Label
            {
                Text = $"Stok: {product.Stock}",
                Location = new Point(10, 205),
                Size = new Size(240, 22),
                BackColor = Color.Transparent,
                ForeColor = Color.DarkGray,
                Font = new Font("Poppins", 8, FontStyle.Regular)
            };

            Label jmlhProduk = new Label
            {
                Text = "0",
                Location = new Point(120, 235),
                Size = new Size(30, 28),
                BackColor = Color.Transparent,
                Font = new Font("Poppins", 9, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };

            Button buttonTambah = new Button
            {
                Location = new Point(160, 233),
                Size = new Size(34, 30),
                Text = "+",
                Font = new Font("Poppins", 9, FontStyle.Bold)
            };

            Button buttonKurang = new Button
            {
                Location = new Point(80, 233),
                Size = new Size(34, 30),
                Text = "-",
                Font = new Font("Poppins", 9, FontStyle.Bold)
            };

            // tambahkan controls ke panel produk
            panel.Controls.Add(displayProduct);
            panel.Controls.Add(namaProduk);
            panel.Controls.Add(hargaProduk);
            panel.Controls.Add(stokProduk);
            panel.Controls.Add(jmlhProduk);
            panel.Controls.Add(buttonTambah);
            panel.Controls.Add(buttonKurang);

            // EVENT: tambah
            buttonTambah.Click += (s, e) =>
            {
                int jumlah = int.Parse(jmlhProduk.Text);
                if (jumlah < product.Stock)
                {
                    jumlah++;
                    jmlhProduk.Text = jumlah.ToString();

                    // tambahkan ke cart
                    cartController.AddToCart(product);
                    UpdateCartUI();
                }
                else
                {
                    MessageBox.Show("Stok tidak cukup", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };

            // EVENT: kurang
            buttonKurang.Click += (s, e) =>
            {
                int jumlah = int.Parse(jmlhProduk.Text);
                if (jumlah > 0)
                {
                    jumlah--;
                    jmlhProduk.Text = jumlah.ToString();

                    cartController.RemoveFromCart(product);
                    UpdateCartUI();
                }
            };

            return panel;
        }

        // --------------------
        // Tombol Checkout (contoh)
        // Pastikan di Form ada tombol checkout yang memanggil method ini (atau hubungkan di Designer)
        // --------------------
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (cartController.Cart.Count == 0)
            {
                MessageBox.Show("Keranjang kosong!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // kurangi stok di DB via controller
            foreach (var item in cartController.Cart.ToList())
            {
                int sisaStok = item.Product.Stock - item.jumlah_item;
                if (sisaStok < 0) sisaStok = 0;

                productController.UpdateStock(item.Product.ProductId, sisaStok);

                // update objek product stock di memory supaya UI konsisten
                item.Product.Stock = sisaStok;
            }

            // bersihkan cart
            cartController.Cart.Clear();
            UpdateCartUI();
            LoadProducts(); // refresh katalog agar stok terbaru terlihat

            MessageBox.Show("Pesanan berhasil dibuat!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // --------------------
        // Beberapa event handler kosong (boleh diisi jika perlu)
        // --------------------
        private void label2_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void KatalogCustomer_Load(object sender, EventArgs e) { }
    }
}
