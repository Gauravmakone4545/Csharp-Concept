using System;

class Student
{
    public string Name;

    public Student(string Name)
    {
        this.Name = Name;     // using 'this'
    }
}

class Test
{
    static void Main()
    {
        Student s = new Student("Gaurav");
        Console.WriteLine(s.Name);
    }
}
