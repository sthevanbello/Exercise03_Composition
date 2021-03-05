using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise03_Prof_Nelio_Alves.Entities.Enums;

namespace Exercise03_Prof_Nelio_Alves.Entities
{
    class Order
    {
        public DateTime Momment { get; set; }
        public OrderStatus Status { get; set; }

        public Client Client { get; set; }
        List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {

        }

        public Order(DateTime momment, OrderStatus status, Client client)
        {
            Momment = momment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Add(item);
        }

        public double Total()
        {
                double total=0;

            foreach (var item in Items)
            {
                total += item.SubTotal();
            }

            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();


            sb.AppendLine("\nOrder momment: " + Momment);
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine(Client.ToString());
            sb.AppendLine("\nOrder items: ");

            foreach (var item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: " + Total().ToString("C"));

            return sb.ToString();
        }

    }
}
