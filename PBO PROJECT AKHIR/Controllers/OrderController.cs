using Npgsql;
using PBO_PROJECT_AKHIR.Database;
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

        // ======================================================
        // 1. INSERT ORDER + ORDER ITEMS (SESUIKAN DENGAN MODEL)
        // ======================================================
        public int CreateOrder(List<OrderItem> items)
        {
            if (items == null || items.Count == 0)
            {
                MessageBox.Show("Tidak ada item pesanan!");
                return -1;
            }

            try
            {
                using var conn = new NpgsqlConnection(_dbContext.connStr);
                conn.Open();
                using var tr = conn.BeginTransaction();

                // Hitung total
                int totalItem = 0;
                int totalHarga = 0;

                foreach (OrderItem item in items)
                {
                    totalItem += item.JumlahItem;
                    totalHarga += item.SubTotal;
                }

                // Insert ke orders
                string qOrder = @"
                    INSERT INTO orders (tanggal_pesanan, jumlah_item, subtotal, status)
                    VALUES (@tanggal, @jumlah, @subtotal, @status)
                    RETURNING order_id;
                ";

                int orderId;

                using (var cmd = new NpgsqlCommand(qOrder, conn))
                {
                    cmd.Transaction = tr;
                    cmd.Parameters.AddWithValue("@tanggal", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@jumlah", totalItem);
                    cmd.Parameters.AddWithValue("@subtotal", totalHarga);
                    cmd.Parameters.AddWithValue("@status", StatusPesanan.Selesai.ToString());

                    orderId = Convert.ToInt32(cmd.ExecuteScalar());
                }

                // Insert order_items
                string qItem = @"
                    INSERT INTO order_items (order_id, nama_produk, harga, qty, gambar)
                    VALUES (@orderid, @nama, @harga, @qty, @gambar);
                ";

                foreach (OrderItem item in items)
                {
                    using var cmdItem = new NpgsqlCommand(qItem, conn);
                    cmdItem.Transaction = tr;

                    cmdItem.Parameters.AddWithValue("@orderid", orderId);
                    cmdItem.Parameters.AddWithValue("@nama", item.ProductName);
                    cmdItem.Parameters.AddWithValue("@harga", item.Price);
                    cmdItem.Parameters.AddWithValue("@qty", item.JumlahItem);
                    cmdItem.Parameters.AddWithValue("@gambar", item.ImageData ?? (object)DBNull.Value);

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

        // ======================================================
        // 2. GET ORDER TERBARU (SESUAI MODEL Orders)
        // ======================================================
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
    }
}