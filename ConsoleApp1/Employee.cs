using System;
using System.Collections.Generic;

namespace EmployeeManagementSystem
{
    public class Employee
    {
        public delegate void MethodCalledEventHandler(object sender, string message); // Event delegate for notification

        private int id;
        private string name;
        private string departmentName;

        public event MethodCalledEventHandler MethodCalled; // Event declaration

        public Employee(int id, string name, string departmentName)
        {
            this.id = id;
            this.name = name;
            this.departmentName = departmentName;
        }

        public int GetId()
        {
            return id;
        }

        public void UpdateId(int newId)
        {
            id = newId;
            MethodCalled?.Invoke(this, $"Employee ID updated to {newId}"); // Raise event after update
        }

        public string GetName()
        {
            return name;
        }

        public void UpdateName(string newName)
        {
            name = newName;
            MethodCalled?.Invoke(this, $"Employee name updated to {newName}"); // Raise event after update
        }

        public string GetDepartmentName()
        {
            return departmentName;
        }

        public void UpdateDepartmentName(string newDepartmentName)
        {
            departmentName = newDepartmentName;
            MethodCalled?.Invoke(this, $"Employee department name updated to {newDepartmentName}"); // Raise event after update
        }
    }
}
