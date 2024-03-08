using System;


//Employee class with properties and methods as per the assignment requirements
public class Employee
{
    private int Id;
    private string Name;
    private string DepartmentName;

    // Define an event to notify when any method is called
    public event EventHandler<string> MethodCalled;

    // Constructor to initialize the Employee object with provided details
    public Employee(int id, string name, string departmentName)
    {
        Id = id;
        Name = name;
        DepartmentName = departmentName;
    }
    // Method to return the Id property
    public int GetId()
    {
        OnMethodCalled("GetId() method called");
        return Id;
    }
    // Method to return the Name property
    public string GetName()
    {
        OnMethodCalled("GetName() method called");
        return Name;
    }
    // Method to return the DepartmentName property
    public string GetDepartmentName()
    {
        OnMethodCalled("GetDepartmentName() method called");
        return DepartmentName;
    }
    // Method to update the Id property
    public void UpdateId(int newId)
    {
        Id = newId;
    }
    // Method to update the Name property
    public void UpdateName(string newName)
    {
        Name = newName;
    }
    // Method to update the DepartmentName property
    public void UpdateDepartmentName(string newDepartmentName)
    {
        DepartmentName = newDepartmentName;
    }
    // Event handler to raise an event when any method is called
    protected virtual void OnMethodCalled(string message)
    {
        MethodCalled?.Invoke(this, message);
    }
}
class Program
{
    static void Main(string[] args)
    {
        //  To enter employee details
        Console.WriteLine("Enter Employee Details:");
        Console.Write("Id: ");
        int id = int.Parse(Console.ReadLine());
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Department Name: ");
        string departmentName = Console.ReadLine();


        // Create an instance of the Employee class with provided details
        Employee emp = new Employee(id, name, departmentName);


     
        emp.MethodCalled += (sender, message) => Console.WriteLine(message);


        // Display the employee details using the Get methods
        Console.WriteLine("\nEmployee Details:");
        Console.WriteLine("Id: " + emp.GetId());
        Console.WriteLine("Name: " + emp.GetName());
        Console.WriteLine("Department Name: " + emp.GetDepartmentName());


        // To update employee details
        Console.WriteLine("\nEnter Updated Details:");
        Console.Write("Id: ");
        emp.UpdateId(int.Parse(Console.ReadLine()));
        Console.Write("Name: ");
        emp.UpdateName(Console.ReadLine());
        Console.Write("Department Name: ");
        emp.UpdateDepartmentName(Console.ReadLine());

        // Display the updated employee details
        Console.WriteLine("\nUpdated Employee Details:");
        Console.WriteLine("Id: " + emp.GetId());
        Console.WriteLine("Name: " + emp.GetName());
        Console.WriteLine("Department Name: " + emp.GetDepartmentName());
    }
}

