using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("1.Employee Table \n2.Product Table \n3.Order Table");
                Console.WriteLine("Select an Option");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        {
                            Console.WriteLine("*****Create Employee*****");
                            EmployeeClass.CreateEmployee();
                            Console.WriteLine("*****Read Employee*****");
                            EmployeeClass.ReadEmployee();
                            Console.WriteLine("*****Update Employee*****");
                            EmployeeClass.UpdateEmployee();
                            Console.WriteLine("*****Delete Employee*****");
                            EmployeeClass.DeleteEmployee();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("*****Create Product*****");
                            ProductClass.CreateProduct();
                            Console.WriteLine("*****Read Product*****");
                            ProductClass.ReadProduct();
                            Console.WriteLine("*****Update Product*****");
                            ProductClass.UpdateProduct();
                            Console.WriteLine("*****Delete Product*****");
                            ProductClass.DeleteProduct();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("*****Create Orders*****");
                            OrderClass.CreateOrders();
                            Console.WriteLine("*****Read Orders*****");
                            OrderClass.ReadOrders();
                            Console.WriteLine("*****Update Orders*****");
                            OrderClass.UpdateOrders();
                            Console.WriteLine("*****Delete Orders*****");
                            OrderClass.DeleteOrders();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid Choice");
                            break;
                        }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}