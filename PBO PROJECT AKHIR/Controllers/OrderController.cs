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
        // Contoh simpan order sementara
        private List<Orders> orderList = new List<Orders>();

        // Contoh method untuk ambil order saat ini (dummy)
        public Orders GetCurrentOrder()
        {
            if (orderList.Count == 0)
            {
                orderList.Add(new Orders()); // inisialisasi dummy
            }
            return orderList[0];
        }
    }
}
