namespace Event_9;

// Publisher class that defines an event
    class Publisher
    {
        public delegate void Notify(); // Declare delegate
        public event Notify OnCompleted; // Declare event

        public void Process()
        {
            Console.WriteLine("Processing...");

            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Process Completed!");

            // Trigger event if there are subscribers
            OnCompleted?.Invoke();
        }
    }

    // Subscriber class that listens to the event
    class Subscriber
    {
        public void EventHandler()
        {
            Console.WriteLine("Subscriber received the event notification.");
        }
    }

class Program
{
    static void Main(string[] args)
    {
        Publisher pub = new Publisher(); // Create Publisher
            Subscriber sub = new Subscriber(); // Create Subscriber

            // Subscribe to the event
            pub.OnCompleted += sub.EventHandler;

            // Start process (will trigger event when completed)
            pub.Process();
    }
}
