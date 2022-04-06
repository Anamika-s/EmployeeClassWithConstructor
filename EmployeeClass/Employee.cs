using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClass
{
    class Employee
    {
        int id;
        string name;
        string address;
        int salary;
        static string dept;


        // Static Constr     , it will be onle one , will be parameterless

        static  Employee()
        {
            dept = "IT";
        }
        // Def Cons CAN BE ONLY ONE WITHIN A CLASS
        public Employee() { }

        //Para Cons CAN BE MULTIPLE  WITHIN A CLASS
        public Employee(int id)
        {
            this.id = id;
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
            Console.WriteLine("Enter Address");
            address = Console.ReadLine();
            Console.WriteLine("Enter Salary");
            salary = int.Parse(Console.ReadLine());

        }
        public Employee(int id, string name)
        {
            this.id = id;

            this.name = name;
            Console.WriteLine("Enter Address");
            address = Console.ReadLine();
            Console.WriteLine("Enter Salary");
            salary = int.Parse(Console.ReadLine());

        }
        public Employee(int id, string name, string address, int salary)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.salary = salary;

        }

        public Employee(Employee employee)

        {
            Console.WriteLine("Enter ID");
            id = Byte.Parse(Console.ReadLine());
            this.name = employee.name;
            this.address = employee.address;
            this.salary = employee.salary;
                }
        public void GetDetails()
        {
            Console.WriteLine("Enter ID");
            id = Byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
            Console.WriteLine("Enter Address");
            address = Console.ReadLine();
            Console.WriteLine("Enter Salary");
            salary = int.Parse(Console.ReadLine());
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"ID is {id}");
            Console.WriteLine($"Name is {name}");
            Console.WriteLine($"Address is {address}");
            Console.WriteLine($"Salary is {salary}");
        }
        public static void DisplayDept()
        {
            Console.WriteLine("Department is "  + dept);
        }
    }
}
