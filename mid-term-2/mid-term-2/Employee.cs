using System;

class Employee : Person
{
    public string employeeID;

    public Employee(string username, string password, string employeeID) : base(username, password)
    {
        this.employeeID = employeeID;
    }

    public string GetEmployeeID()
    {
        return this.employeeID;
    }
}