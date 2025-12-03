using System;

class Publisher
{
    public event Action OnPublish;   // event

    public void Publish()
    {
        Console.WriteLine("Publishing event...");
        OnPublish?.Invoke();         // trigger event
    }
}

class Subscriber
{
    public void OnEventReceived()
    {
        Console.WriteLine("Subscriber received the event!");
    }
}

class EventExample
{
    static void Main()
    {
        Publisher pub = new Publisher();
        Subscriber sub = new Subscriber();

        // event subscription
        pub.OnPublish += sub.OnEventReceived;

        pub.Publish();  // event fire
    }
}
