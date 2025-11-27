using Npgsql;
using PBO_PROJECT_AKHIR.Database;
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
                    string query = @"INSERT INTO products(product_name, image, price, strock) VALUE(";
                }
            } catch (Exception ex)
            {
                MessageBox.Show($"Create Product ERROR: {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
