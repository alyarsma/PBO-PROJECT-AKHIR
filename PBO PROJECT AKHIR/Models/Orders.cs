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
        public string Alamat { get; set; }
        public int JumlahItem { get; set; }
        public int SubTotal { get; set; }
        public StatusPesanan Status { get; set; }
    }

    public enum StatusPesanan
    {
        [Description("Menunggu Dikonfirmasi")]
        MenungguDikonfirmasi,

        [Description("Dikirim")]
        Dikirim,

        [Description("Selesai")]
        Selesai,

        [Description("Dibatalkan")]
        Dibatalkan
    }
}
