using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_PROJECT_AKHIR.Models
{
    public class Product
    {
        // Identitas Produk
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public byte[] Image { get; set; }

        public int Price { get; set; }
        public int Stock { get; set; }
        public int SelectedQty { get; set; } = 0;
    }
}
