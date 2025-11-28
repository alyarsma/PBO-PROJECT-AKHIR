using PBO_PROJECT_AKHIR.Controllers;
using PBO_PROJECT_AKHIR.Helpers;
using PBO_PROJECT_AKHIR.Interfaces;
using PBO_PROJECT_AKHIR.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBO_PROJECT_AKHIR.Views.Admin
{
    public partial class TambahProduk : Form
    {
        private OpenFileDialog openFileDialog;
        private IProduk productController;
        public TambahProduk()
        {
            InitializeComponent();
            openFileDialog = new OpenFileDialog();
            productController = new ProductController();
        }

        private void btnuploadfoto_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedItem = openFileDialog.FileName;
                pbgambarproduk.Image = Image.FromFile(selectedItem);
            }
        }

        private void btnsimpanproduk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(openFileDialog.FileName))
            {
                MessageBox.Show("Pilih gambar terlebih dahulu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Image gambarproduk = pbgambarproduk.Image;
            string namaProduk = tbnamaproduk.Text;
            int hargaProduk = int.Parse(tbhargaproduk.Text);
            int stokProduk = int.Parse(tbstokproduk.Text);

            try
            {
                Product product = new Product
                {
                    Image = ImageHelper.ImageToBinary(gambarproduk),
                    ProductName = namaProduk,
                    Stock = stokProduk,
                    Price = hargaProduk,
                    //UserId = AppSession.CurrentUser.UserId,
                };

                productController.CreateProduct(product);
                MessageBox.Show("Produk berhasil ditambahkan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

                var katalogAdmin = new KatalogAAdmin(productController);
                katalogAdmin.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal menambahkan produk {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnbatalsimpan_Click(object sender, EventArgs e)
        {
            KatalogAAdmin katalogAdmin = new KatalogAAdmin(productController);
            katalogAdmin.FormClosed += (s, args) => this.Close();
            katalogAdmin.Show();
            this.Hide();
        }
    }
}
