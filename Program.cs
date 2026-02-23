using System;
using System.Threading;

namespace FastXEAdminAgent
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FastXE Admin Agent started...");

            // Run continuously until user presses Ctrl+C
            while (true)
            {
                // Example: log the current timestamp
                Console.WriteLine($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] Agent is running...");

                // Here you can call your API or add your agent logic
                // Example: Simulate work
                Thread.Sleep(5000); // Wait 5 seconds
            }
        }
    }
}