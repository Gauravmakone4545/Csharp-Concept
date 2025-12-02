using System;

class A 
{
	public void Amethod() => 
   Console.WriteLine("A"); 
}
class B : A 
{ 
	public void Bmethod() =>
	Console.WriteLine("B"); 
}
class C : B 
{
	public void Cmethod() =>
	Console.WriteLine("C");
}

class Test
{
	static void Main()
	{
		C obj = new C();
		obj.Amethod();
		obj.Bmethod();
		obj.Cmethod();
	}
}
