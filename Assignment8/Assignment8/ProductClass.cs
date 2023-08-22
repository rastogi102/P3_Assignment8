using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    public class ProductClass
    {
        static AdvancedEDbEntities db;
        public static void CreateProduct()
        {
            db = new AdvancedEDbEntities();
            Product product = new Product();
            Console.WriteLine("Enter Product ID: ");
            product.ProductId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Product Name: ");
            product.ProductName = Console.ReadLine();
            Console.WriteLine("Enter Product Description: ");
            product.Description = Console.ReadLine();
            Console.WriteLine("Enter Price: ");
            product.Price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter Release Date: ");
            product.ReleaseDate = DateTime.Parse(Console.ReadLine());
            db.Products.Add(product);
            db.SaveChanges();
            Console.WriteLine("Product inserted!!");
        }
        public static void ReadProduct()
        {
            db = new AdvancedEDbEntities();
            foreach (Product p in db.Products)
            {
                Console.WriteLine("ID: " + p.ProductId);
                Console.WriteLine("First Name: " + p.ProductName);
                Console.WriteLine("Description: " + p.Description);
                Console.WriteLine("Price: " + p.Price);
                Console.WriteLine("Release Date: " + p.ReleaseDate);
                Console.WriteLine("");
            }
        }
        public static void UpdateProduct()
        {
            Product product;
            db = new AdvancedEDbEntities();
            Console.WriteLine("Enter ID to update the details: ");
            int Id = int.Parse(Console.ReadLine());
            product = db.Products.SingleOrDefault(x => x.ProductId == Id);

            if (product == null)
            {
                Console.WriteLine("No such ID exist");
            }
            else
            {
                Console.WriteLine("Enter Product Name: ");
                product.ProductName = Console.ReadLine();
                Console.WriteLine("Enter Product Description: ");
                product.Description = Console.ReadLine();
                Console.WriteLine("Enter Price: ");
                product.Price = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Enter Release Date: ");
                product.ReleaseDate = DateTime.Parse(Console.ReadLine());
                db.SaveChanges();
                Console.WriteLine("Product updated!!");
            }
        }
        public static void DeleteProduct()
        {
            Product product;
            db = new AdvancedEDbEntities();
            Console.WriteLine("Enter ID to delete record: ");
            int Id = int.Parse(Console.ReadLine());
            product = db.Products.SingleOrDefault(x => x.ProductId == Id);

            if (product == null)
            {
                Console.WriteLine("No such ID exist");
            }
            else
            {
                db.Products.Remove(product);
                db.SaveChanges();
                Console.WriteLine("Product Deleted!!");
            }
        }
    }
}
