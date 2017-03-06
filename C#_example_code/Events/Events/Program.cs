// Events

using System;
using System.Threading;
using System.Threading.Tasks;

class EventSource
{
    public event EventHandler<string> Timeout; // event member
    public void StartTimeout(int milliSeconds) // spin in background
    {
        Task task = Task.Factory.StartNew( // ignore crazy threading stuff!
            () => {
                Thread.Sleep(milliSeconds);
                Timeout(this, "Timeout complete!");
            });
    }
}

class Program
{
    static void Main()
    {
        EventSource es = new EventSource(); // create object that raises event
        es.Timeout += EventSource_Timeout;  // wire-up event handler to event source
        es.StartTimeout(2000);              // 2 second delay
        Console.WriteLine("Waiting for Timeout to complete...");
        Console.ReadLine();                 // prevent program ending to soon
    }

    private static void EventSource_Timeout(object sender, string e)
    {
        Console.WriteLine(e); // handle Timeout event
    }
}


