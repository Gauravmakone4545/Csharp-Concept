using System;

class Employee
{
    public string Name { get; set; }
    public int Salary { get; private set; }  // read-only

    public void SetSalary(int s)
    {
        Salary = s;
    }
}

class Test
{
    static void Main()
    {
        Employee e = new Employee();
        e.Name = "Gaurav";
        e.SetSalary(25000);

        Console.WriteLine(e.Name + " " + e.Salary);
    }
}
