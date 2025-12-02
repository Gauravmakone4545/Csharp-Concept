using System;

class Person
{
	public string Name;
	public int Age;
}

class Test
{
	static void Main()
	{
		Person p = new Person();
		p.Name = "Gaurav";
		p.Age = 23;

		Console.WriteLine(p.Name + " " + p.Age);
	}
}
