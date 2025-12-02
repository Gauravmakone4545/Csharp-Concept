using System;

class Parent
{
	public void ShowParent() => Console.WriteLine("Parent Class");
}

class Child : Parent
{
	public void ShowChild() => Console.WriteLine("Child Class");
}

class Test
{
	static void Main()
	{
		Child c = new Child();
		c.ShowParent();
		c.ShowChild();
	}
}
