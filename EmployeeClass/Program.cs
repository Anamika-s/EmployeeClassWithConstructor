using System;

namespace EmployeeClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee.DisplayDept();

            // This will call def cons
            Employee employee1 = new Employee();
            employee1.GetDetails();
            employee1.DisplayDetails();

            // This will call para cons
            Employee employee2 = new Employee(100);
            employee2.DisplayDetails();

            // This will call para cons
            Employee employee3 = new Employee(101, "Deepak");
            employee3.DisplayDetails();

            // This will call para cons
            Employee employee4 = new Employee(103, "Ajay", "Delhi", 30000);
            employee4.DisplayDetails();

            // This will call copy cons
            Console.WriteLine("Copy const will  be called here");
            Employee employee5 = new Employee(employee4);
            employee5.DisplayDetails();

        }
    }
}
