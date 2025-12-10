using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_PROJECT_AKHIR.Models
{
    public class Orders
    {
        public int OrderId { get; set; }

        public string TanggalPesanan { get; set; }
        public int JumlahItem { get; set; }       // total semua item
        public int Subtotal { get; set; }      // total harga semua item
        public StatusPesanan Status { get; set; }
    }

    public enum StatusPesanan
    {

        [Description("Selesai")]
        Selesai,

        [Description("Dibatalkan")]
        Dibatalkan
    }

    public class OrderItem
    {
        public string ProductName { get; set; }         // nama produk
        public int Price { get; set; }           // harga satuan
        public int JumlahItem { get; set; }             // jumlah dibeli
        public byte[] ImageData { get; set; }   // gambar dari database

        public int SubTotal => Price * JumlahItem;      // subtotal produk

        public Image Image
        {
            get
            {
                if (ImageData == null) return null;
                using (var ms = new MemoryStream(ImageData))
                {
                    return Image.FromStream(ms);
                }
            }
        }
    }
}
