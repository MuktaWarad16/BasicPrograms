using System;
using System.Diagnostics;

class ExecutionTime
{
    //static void Main()
    //{
        
    //    Stopwatch stopwatch = new Stopwatch();

        
    //    stopwatch.Start();

        
    //    PerformTask();

        
    //    stopwatch.Stop();

        
    //    Console.WriteLine("Execution time of the program: " + stopwatch.ElapsedMilliseconds + " milliseconds");
    //}

    
    static void PerformTask()
    {
        
        Console.WriteLine("Task is starting...");

        
        System.Threading.Thread.Sleep(3000);

        Console.WriteLine("Task is complete.");
    }
}
