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
    }
}
