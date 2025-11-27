using Npgsql;
using PBO_PROJECT_AKHIR.Database;
using PBO_PROJECT_AKHIR.Helpers;
using PBO_PROJECT_AKHIR.Interfaces;
using PBO_PROJECT_AKHIR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_PROJECT_AKHIR.Controllers
{
    public class ProductController : IProduk
    {
        private readonly DbContext _dbContext;

        public ProductController()
        {
            _dbContext = new DbContext();
        }

        public void CreateProduct(Product product)
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(_dbContext.connStr))
                {
                    conn.Open();
                    string query = @"INSERT INTO products(product_name, image, price, stock) 
                             VALUES (@product_name, @image, @price, @stock)";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@product_name", product.ProductName);
                        cmd.Parameters.AddWithValue("@image", product.Image);
                        cmd.Parameters.AddWithValue("@price", product.Price);
                        cmd.Parameters.AddWithValue("@stock", product.Stock);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Create Product ERROR: {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<Product> GetAllProduct()
        {
            List<Product> products = new List<Product>();

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(_dbContext.connStr))
                {
                    conn.Open();
                    string query = @"SELECT product_id, product_name,image, price, stock FROM products";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Product product = new Product
                                {
                                    ProductId = reader.GetInt32(0),
                                    ProductName = reader.GetString(1),
                                    Image = reader["image"] as byte[],
                                    Price = reader.GetInt32(2),
                                    Stock = reader.GetInt32(3)
                                };
                                products.Add(product);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Get Product Error: {ex.Message}");
            }

            return products;   // ini yang benar
        }

        public void UpdateStock(int productId, int newStock)
        {
            try
            {
                using (var conn = new NpgsqlConnection(_dbContext.connStr))
                {
                    conn.Open();

                    string query = "UPDATE products SET stock = @stock WHERE product_id = @product_id";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@stock", newStock);
                        cmd.Parameters.AddWithValue("@product_id", productId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Update Stock ERROR: {ex.Message}");
            }
        }
    }
}
