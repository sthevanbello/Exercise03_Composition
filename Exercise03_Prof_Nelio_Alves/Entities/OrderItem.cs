using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03_Prof_Nelio_Alves.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {

        }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Product name: " + Product.Name + ", ");
            sb.Append("Price: " + Product.Price.ToString("C") + ", ");
            sb.Append("Quantity: " + Quantity + ", ");
            sb.Append("Subtotal: " + SubTotal().ToString("C"));


            return sb.ToString();
        }


    }
}
