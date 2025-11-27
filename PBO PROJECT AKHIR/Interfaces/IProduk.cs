using PBO_PROJECT_AKHIR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_PROJECT_AKHIR.Interfaces
{
    public interface IProduk
    {
        void CreateProduct(Product product);
        List<Product> GetAllProduct();
    }
}
