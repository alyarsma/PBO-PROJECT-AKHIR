using PBO_PROJECT_AKHIR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_PROJECT_AKHIR.Controllers
{
    public class CartController
    {
        public List<CartItem> Cart { get; private set; } = new List<CartItem>();

        public void AddToCart(Product product)
        {
            var item = Cart.FirstOrDefault(x => x.Product.ProductId == product.ProductId);
            if (item == null)
            {
                Cart.Add(new CartItem
                {
                    Product = product,
                    jumlah_item = 1
                });
            }
            else
            {
                if (item.jumlah_item < product.Stock)
                    item.jumlah_item++;
            }
        }

        public void RemoveFromCart(Product product)
        {
            var item = Cart.FirstOrDefault(x => x.Product.ProductId == product.ProductId);
            if (item != null)
            {
                item.jumlah_item--;
                if (item.jumlah_item <= 0)
                    Cart.Remove(item);
            }
        }

        public decimal GetTotal()
        {
            return Cart.Sum(c => c.Product.Price * c.jumlah_item);
        }
    }
}
