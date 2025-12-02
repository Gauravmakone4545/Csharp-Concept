using System;

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Test
{
    static void Main()
    {
        Student s = new Student();
        s.Name = "Gaurav";
        s.Age = 22;

        Console.WriteLine(s.Name + " " + s.Age);
    }
}
