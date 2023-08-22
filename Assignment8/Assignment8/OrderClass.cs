using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    public class OrderClass
    {
        static AdvancedEDbEntities db;
        public static void CreateOrders()
        {
            db = new AdvancedEDbEntities();
            Order order = new Order();
            Console.WriteLine("Enter Order ID: ");
            order.OrderId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Order Date: ");
            order.OrderDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter Quantity: ");
            order.Quantity = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Enter Discount: ");
            order.Discount = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter IsShipped: ");
            order.IsShipped = Boolean.Parse(Console.ReadLine());
            db.Orders.Add(order);
            db.SaveChanges();
            Console.WriteLine("Order inserted!!");
        }
        public static void ReadOrders()
        {
            db = new AdvancedEDbEntities();
            foreach (Order order in db.Orders)
            {
                Console.WriteLine("ID: " + order.OrderId);
                Console.WriteLine("Order Date: " + order.OrderDate);
                Console.WriteLine("Quantity: " + order.Quantity);
                Console.WriteLine("Discount: " + order.Discount);
                Console.WriteLine("IsShipped: " + order.IsShipped);
                Console.WriteLine("");
            }
        }
        public static void UpdateOrders()
        {
            Order order;
            db = new AdvancedEDbEntities();
            Console.WriteLine("Enter ID to update the details: ");
            int Id = int.Parse(Console.ReadLine());
            order = db.Orders.SingleOrDefault(x => x.OrderId == Id);

            if (order == null)
            {
                Console.WriteLine("No such ID exist");
            }
            else
            {
                Console.WriteLine("Enter Order Date: ");
                order.OrderDate = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Enter Quantity: ");
                order.Quantity = Int16.Parse(Console.ReadLine());
                Console.WriteLine("Enter Discount: ");
                order.Discount = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter IsShipped: ");
                order.IsShipped = Boolean.Parse(Console.ReadLine());
                db.SaveChanges();
                Console.WriteLine("Order updated!!");
            }
        }
        public static void DeleteOrders()
        {
            Order order;
            db = new AdvancedEDbEntities();
            Console.WriteLine("Enter ID to delete record: ");
            int Id = int.Parse(Console.ReadLine());
            order = db.Orders.SingleOrDefault(x => x.OrderId == Id);

            if (order == null)
            {
                Console.WriteLine("No such ID exist");
            }
            else
            {
                db.Orders.Remove(order);
                db.SaveChanges();
                Console.WriteLine("Order Deleted!!");
            }
        }
    }
}
