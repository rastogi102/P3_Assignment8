using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    public class EmployeeClass
    {
        static AdvancedEDbEntities db;
        public static void CreateEmployee()
        {
            db = new AdvancedEDbEntities();
            Employee emp = new Employee();
            Console.WriteLine("Enter Employee ID: ");
            emp.EmployeeId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter First Name: ");
            emp.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name: ");
            emp.LastName = Console.ReadLine();
            Console.WriteLine("Enter Salary: ");
            emp.Salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Date of Birth: ");
            emp.BirthDate = DateTime.Parse(Console.ReadLine());
            db.Employees.Add(emp);
            db.SaveChanges();
            Console.WriteLine("employee inserted!!");
        }
        public static void ReadEmployee()
        {
            db = new AdvancedEDbEntities();
            foreach (Employee e in db.Employees)
            {
                Console.WriteLine("ID: " + e.EmployeeId);
                Console.WriteLine("First Name: " + e.FirstName);
                Console.WriteLine("Last Name: " + e.LastName);
                Console.WriteLine("Salary: " + e.Salary);
                Console.WriteLine("Date of Joining: " + e.BirthDate);
                Console.WriteLine("");
            }
        }
        public static void UpdateEmployee()
        {
            Employee emp;
            db = new AdvancedEDbEntities();
            Console.WriteLine("Enter ID to update the details: ");
            int Id = int.Parse(Console.ReadLine());
            emp = db.Employees.SingleOrDefault(x => x.EmployeeId == Id);

            if (emp == null)
            {
                Console.WriteLine("No such ID exist");
            }
            else
            {
                Console.WriteLine("Enter new First Name: ");
                emp.FirstName = Console.ReadLine();
                Console.WriteLine("Enter new Last Name: ");
                emp.LastName = Console.ReadLine();
                Console.WriteLine("Enter new Salary: ");
                emp.Salary = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Date of Birth: ");
                emp.BirthDate = DateTime.Parse(Console.ReadLine());
                db.SaveChanges();
                Console.WriteLine("employee record updated!!");
            }
        }
        public static void DeleteEmployee()
        {
            Employee emp;
            db = new AdvancedEDbEntities();
            Console.WriteLine("Enter ID to delete record: ");
            int Id = int.Parse(Console.ReadLine());
            emp = db.Employees.SingleOrDefault(x => x.EmployeeId == Id);

            if (emp == null)
            {
                Console.WriteLine("No such ID exist");
            }
            else
            {
                db.Employees.Remove(emp);
                db.SaveChanges();
                Console.WriteLine("employee record Deleted!!");
            }
        }
    }
}
