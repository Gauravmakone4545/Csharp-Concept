using System;

class Student
{
    public string Name { get; set; }
}

class MyData<T> where T : class
{
    public T Value { get; set; }

    public void Show()
    {
        Console.WriteLine("Value: " + Value);
    }
}

class GenericsWithConstraints
{
    static void Main()
    {
        MyData<Student> obj = new MyData<Student>
        {
            Value = new Student { Name = "Gaurav" }
        };

        obj.Show();
    }
}
