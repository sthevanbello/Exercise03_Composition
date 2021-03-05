using Exercise03_Prof_Nelio_Alves.Entities;
using Exercise03_Prof_Nelio_Alves.Entities.Enums;
using System;
using System.Globalization;

namespace Exercise03_Prof_Nelio_Alves
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter client data: ");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("E-mail: ");
            string email = Console.ReadLine();

            Console.Write("Birth date (MM/DD/YYYY): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);


            Console.WriteLine("Enter order data: ");
            Console.Write("Status: (PendingPayment / Processing / Shipped / Delivered): ");
            string orderStatus = Console.ReadLine();
            OrderStatus status = (OrderStatus)Enum.Parse(typeof(OrderStatus), orderStatus);

            Client client1 = new Client(name, email, date );

            Order order = new Order(momment: DateTime.Now, status: status, client: client1);


            Console.Write("How many items to this order? : ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string nameProduct = Console.ReadLine();

                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine());

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(nameProduct, productPrice);

                OrderItem item = new OrderItem(quantity, productPrice, product);

                order.AddItem(item);

            }

            Console.WriteLine("\nOrder Summary: ");

            Console.WriteLine(order);

            Console.ReadKey();
        }
    }
}
