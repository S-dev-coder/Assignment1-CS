using EmployeeManagementSystem;
using System;

namespace EmployeeManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee details:");
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Department Name: ");
            string departmentName = Console.ReadLine();

            // Create Employee object with event subscription
            Employee employee = new Employee(id, name, departmentName);
            employee.MethodCalled += (sender, message) => Console.WriteLine(message); // Event handler

            Console.WriteLine("\nEmployee details:");
            Console.WriteLine($"Id: {employee.GetId()}");
            Console.WriteLine($"Name: {employee.GetName()}");
            Console.WriteLine($"Department Name: {employee.GetDepartmentName()}");

            Console.WriteLine("\nEnter new details to update:");
            Console.Write("New Id: ");
            int newId = int.Parse(Console.ReadLine());
            Console.Write("New Name: ");
            string newName = Console.ReadLine();
            Console.Write("New Department Name: ");
            string newDepartmentName = Console.ReadLine();

            employee.UpdateId(newId);
            employee.UpdateName(newName);
            employee.UpdateDepartmentName(newDepartmentName);

            Console.WriteLine("\nUpdated Employee details:");
            Console.WriteLine($"Id: {employee.GetId()}");
            Console.WriteLine($"Name: {employee.GetName()}");
            Console.WriteLine($"Department Name: {employee.GetDepartmentName()}");
        }
    }
}
