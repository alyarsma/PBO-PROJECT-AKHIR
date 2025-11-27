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
        private DbContext _dbContext;

        public ProductController()
        {

        }

        public void CreateProduct(Product product)
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(_dbContext.connStr))
                {
                    conn.Open();
                    string query = @"INSERT INTO products(product_name, image, price, stock) VALUE(@product_name, @image, @price, @stock)";

                    using (NpgsqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.Parameters.AddWithValue("@productName", product.ProductName);
                        cmd.Parameters.AddWithValue("@image", product.Image);
                        cmd.Parameters.AddWithValue("@price", product.Price);
                        cmd.Parameters.AddWithValue("@stock", product.Stock);
                     //   cmd.Parameters.AddWithValue("@user_id", product.UserId);

                        cmd.ExecuteNonQuery();
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show($"Create Product ERROR: {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //public List<Product> GetByUserId(int userId)
        //{
        //    List<Product> products = new List<Product>();

        //    try
        //    {
        //        using (NpgsqlConnection conn = new NpgsqlConnection(_dbContext.connStr))
        //        {
        //            conn.Open();
        //            string query = @"SELECT product_id, product_name, price, stock FROM product FROM product WHERE user_id = @userId";
        //        }
        //    } catch (Exception ex)
        //    {
        //        MessageBox.Show($"Get Product By UserID ERROR: {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

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
                                    Price = reader.GetInt32(2),
                                    Stock = reader.GetInt32(3),
                                    Image = reader["image"] as byte[]
                                };
                                products.Add(product);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Get Product By UserID Error: {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return new List<Product>();
        }
    }
}
