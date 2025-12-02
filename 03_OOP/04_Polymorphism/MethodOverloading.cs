using System;

class MathOps
{
	public int Add(int a, int b) =>
		a + b;
	public double Add(double a, double b) =>
		a + b;
}

class Test
{
	static void Main()
	{
		MathOps m = new MathOps();
		Console.WriteLine(m.Add(2, 3));
		Console.WriteLine(m.Add(2.5, 3.1));
	}
}
