using System;
using System.Collections.Generic;

class QueueExample
{
	static void Main()
	{
		Queue<string> q = new Queue<string>();

		q.Enqueue("A");
		q.Enqueue("B");
		q.Enqueue("C");

		Console.WriteLine("Front element: " + q.Peek()); // A

		Console.WriteLine("Removing: " + q.Dequeue());

		Console.WriteLine("Queue left:");
		foreach (var x in q)
			Console.WriteLine(x);
	}
}
