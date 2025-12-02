using System;

class Employee
{
    public string Name;
    public int Salary;

    public Employee(string name, int salary)
    {
        Name = name;
        Salary = salary;
    }

    public Employee(Employee e)
    {
        Name = e.Name;
        Salary = e.Salary;
    }
}

class Test
{
    static void Main()
    {
        Employee e1 = new Employee("Gaurav", 50000);
        Employee e2 = new Employee(e1);

        Console.WriteLine(e2.Name + " " + e2.Salary);
    }
}

