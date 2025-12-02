using System;

class Student
{
    public string Name;
    public int Age;

    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

class Test
{
    static void Main()
    {
        Student s = new Student("Gaurav", 22);
        Console.WriteLine(s.Name + " " + s.Age);
    }
}
