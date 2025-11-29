using PBO_PROJECT_AKHIR.Controllers;
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
    public partial class EditProduk : Form
    {
        private IProduk productController;
        private OpenFileDialog openFileDialog;
        public Product Product;

        public EditProduk(IProduk productController, Product product)
        {
            InitializeComponent();
            openFileDialog = new OpenFileDialog();
            //productController = new ProductController();
            this.productController = productController;
            Product = product;
            tbeditnamaproduk.Text = product.ProductName;
            tbedithargaproduk.Text = product.Price.ToString();
            tbeditstokproduk.Text = product.Stock.ToString();
            pictureBox1.Image = Image.FromStream(new MemoryStream(product.Image));
        }

        private void pictureBox1_Click(object sender, EventArgs e)//harusnya pbgambarprodukbaru
        {

        }

        private void btnupfotobaru_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string selectedItem = openFileDialog.FileName;
                    pictureBox1.Image = Image.FromFile(selectedItem);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Pilih gambar terlebih dahulu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnsimpanedit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbeditnamaproduk.Text))
            {
                MessageBox.Show("Nama produk tidak boleh kosong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Product.ProductName = tbeditnamaproduk.Text;

            if (!int.TryParse(tbedithargaproduk.Text, out int price))
            {
                MessageBox.Show("Harga produk harus berupa angka!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Product.Price = price;

            if (pictureBox1.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    Product.Image = ms.ToArray();
                }
            }

            DialogResult result = MessageBox.Show("Apakah anda yakin ingin mengubah?", "Konfirmasi Edit", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                //productController.EditProduk(Product);
                this.productController.EditProduk(Product);
                MessageBox.Show("Produk berhasil diubah.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }
    }
}
