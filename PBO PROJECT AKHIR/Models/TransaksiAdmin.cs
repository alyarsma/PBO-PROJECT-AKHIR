
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_PROJECT_AKHIR.Models
{
    public class transaksi
    {
        public int transaksi_id { get; set; }
        public int user_id { get; set; }
        public DateTime tanggal_transaksi { get; set; }
        public int total_harga { get; set; }
        public int pembayaran_id { get; set; }

        // Tambahkan list detail
        public List<detail_transaksi> DetailTransaksiList { get; set; }
    }

    public class detail_transaksi
    {
        public int detail_id { get; set; }
        public int transaksi_id { get; set; }
        public int product_id { get; set; }
        public string product_name { get; set; }

        public int jumlah_item { get; set; }
        public int price { get; set; }
    }
}
