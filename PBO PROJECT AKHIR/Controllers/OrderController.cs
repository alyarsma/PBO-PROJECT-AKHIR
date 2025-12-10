using Npgsql;
using PBO_PROJECT_AKHIR.Database;
using PBO_PROJECT_AKHIR.Helpers;
using PBO_PROJECT_AKHIR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_PROJECT_AKHIR.Controllers
{
    public class OrderController
    {
        private readonly DbContext _dbContext;

        public OrderController()
        {
            _dbContext = new DbContext();
        }
        public int CreateOrder(List<OrderItem> items)
        {
            if (items == null || items.Count == 0)
            {
                MessageBox.Show("Tidak ada item pesanan!");
                return -1;
            }

            // 🔥 CEK USER LOGIN
            if (AppSession.CurrentUser == null)
            {
                MessageBox.Show("User belum login. Tidak bisa membuat order.");
                return -1;
            }

            MessageBox.Show("User ID yg dipakai = " + AppSession.CurrentUser.UserId);

            try
            {
                using var conn = new NpgsqlConnection(_dbContext.connStr);
                conn.Open();
                using var tr = conn.BeginTransaction();

                int totalItem = 0;
                int totalHarga = 0;

                foreach (OrderItem item in items)
                {
                    totalItem += item.JumlahItem;
                    totalHarga += item.SubTotal;
                }

                // 🔥 TAMBAH user_id DI QUERY
                string qOrder = @"
            INSERT INTO orders (tanggal_pesanan, jumlah_item, subtotal, status, user_id)
            VALUES (@tanggal, @jumlah, @subtotal, @status::status_order, @user)
            RETURNING order_id;
        ";

                int orderId;

                using (var cmd = new NpgsqlCommand(qOrder, conn))
                {
                    cmd.Transaction = tr;

                    cmd.Parameters.AddWithValue("@tanggal", DateTime.Now);
                    cmd.Parameters.AddWithValue("@jumlah", totalItem);
                    cmd.Parameters.AddWithValue("@subtotal", totalHarga);
                    cmd.Parameters.AddWithValue("@status", StatusPesanan.pending.ToString().ToLower());

                    // 🔥 PARAMETER user_id
                    cmd.Parameters.AddWithValue("@user", AppSession.CurrentUser.UserId);



                    orderId = Convert.ToInt32(cmd.ExecuteScalar());
                }

                string qItem = @"
    INSERT INTO order_items (order_id, product_name, price, jumlah_item, subtotal, image_data)
    VALUES (@orderid, @product_name, @price, @jumlah_item, @subtotal, @image_data);
";

                foreach (OrderItem item in items)
                {
                    using var cmdItem = new NpgsqlCommand(qItem, conn);
                    cmdItem.Transaction = tr;

                    cmdItem.Parameters.AddWithValue("@orderid", orderId);
                    cmdItem.Parameters.AddWithValue("@product_name", item.ProductName);
                    cmdItem.Parameters.AddWithValue("@price", item.Price);
                    cmdItem.Parameters.AddWithValue("@jumlah_item", item.JumlahItem);
                    cmdItem.Parameters.AddWithValue("@subtotal", item.SubTotal);

                    // 🔥 Tambahkan image_data di sini
                    cmdItem.Parameters.AddWithValue("@image_data",
                        item.ImageData ?? (object)DBNull.Value);

                    cmdItem.ExecuteNonQuery();
                }

                tr.Commit();
                return orderId;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR CreateOrder: {ex.Message}");
                return -1;
            }
        }

        public Orders GetCurrentOrder()
        {
            using var conn = new NpgsqlConnection(_dbContext.connStr);
            conn.Open();

            string query = @"
                SELECT order_id, tanggal_pesanan, jumlah_item, subtotal, status
                FROM orders
                ORDER BY order_id DESC LIMIT 1;
            ";

            using var cmd = new NpgsqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                return new Orders
                {
                    OrderId = reader.GetInt32(0),
                    TanggalPesanan = reader.GetString(1),
                    JumlahItem = reader.GetInt32(2),
                    Subtotal = reader.GetInt32(3),   // perbaikan
                    Status = Enum.Parse<StatusPesanan>(reader.GetString(4))
                };
            }

            return null;
        }

        public List<Orders> GetAllOrders()
        {
            var list = new List<Orders>();

            using var conn = new NpgsqlConnection(_dbContext.connStr);
            conn.Open();

            // Ambil semua order
            string qOrders = @"
        SELECT order_id, tanggal_pesanan, jumlah_item, subtotal, status, user_id
        FROM orders
        ORDER BY order_id DESC;
    ";

            using (var cmd = new NpgsqlCommand(qOrders, conn))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    list.Add(new Orders
                    {
                        OrderId = reader.GetInt32(0),
                        TanggalPesanan = reader.GetDateTime(1).ToString("yyyy-MM-dd HH:mm"),
                        JumlahItem = reader.GetInt32(2),
                        Subtotal = reader.GetInt32(3),
                        Status = Enum.Parse<StatusPesanan>(reader.GetString(4)),
                        UserId = reader.GetInt32(5),
                        Items = new List<OrderItem>()
                    });
                }
            }

            // Ambil detail item tiap order
            foreach (var order in list)
            {
                string qDetail = @"
            SELECT product_name, price, jumlah_item, subtotal
            FROM order_items
            WHERE order_id = @id;
        ";

                using var cmdDet = new NpgsqlCommand(qDetail, conn);
                cmdDet.Parameters.AddWithValue("@id", order.OrderId);

                using var readerDet = cmdDet.ExecuteReader();
                while (readerDet.Read())
                {
                    order.Items.Add(new OrderItem
                    {
                        ProductName = readerDet.GetString(0),
                        Price = readerDet.GetInt32(1),
                        JumlahItem = readerDet.GetInt32(2),
                    });
                }
            }

            return list;
        }


        public bool UpdateOrderStatus(int orderId, StatusPesanan newStatus)
        {
            try
            {
                using var conn = new NpgsqlConnection(_dbContext.connStr);
                conn.Open();

                string query = @"
            UPDATE orders 
            SET status = @status::status_order
            WHERE order_id = @id;
        ";

                using var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@status", newStatus.ToString().ToLower());
                cmd.Parameters.AddWithValue("@id", orderId);

                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal update status: " + ex.Message);
                return false;
            }
        }

    }
}