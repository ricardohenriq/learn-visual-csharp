using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/*
Thread pooling is a form of multithreading in which tasks are added to a queue and 
automatically started when threads are created.For more information, see Pooling de 
thread (C# e Visual Basic).
The following example uses the .NET Framework thread pool to calculate the Fibonacci 
result for ten numbers between 20 and 40.Each Fibonacci result is represented by the 
Fibonacci class, which provides a method named ThreadPoolCallback that performs the 
calculation.An object that represents each Fibonacci value is created, and the 
ThreadPoolCallback method is passed to QueueUserWorkItem, which assigns an available 
thread in the pool to execute the method.
Because each Fibonacci object is given a semi-random value to compute, and because each 
thread will be competing for processor time, you cannot know in advance how long it will 
take for all ten results to be calculated.That is why each Fibonacci object is passed an 
instance of the ManualResetEvent class during construction.Each object signals the 
provided event object when its calculation is complete, which allows the primary thread to 
block execution with WaitAll until all ten Fibonacci objects have calculated a result.The 
Main method then displays each Fibonacci result.
*/

namespace ThreadsPool
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const int FibonacciCalculations = 10;

            // One event is used for each Fibonacci object.
            ManualResetEvent[] doneEvents = new ManualResetEvent[FibonacciCalculations];
            Fibonacci[] fibArray = new Fibonacci[FibonacciCalculations];
            Random r = new Random();

            // Configure and start threads using ThreadPool.
            Console.WriteLine("launching {0} tasks...", FibonacciCalculations);
            for (int i = 0; i < FibonacciCalculations; i++)
            {
                doneEvents[i] = new ManualResetEvent(false);
                Fibonacci f = new Fibonacci(r.Next(20, 40), doneEvents[i]);
                fibArray[i] = f;
                ThreadPool.QueueUserWorkItem(f.ThreadPoolCallback, i);
            }

            // Wait for all threads in pool to calculate.
            WaitHandle.WaitAll(doneEvents);
            Console.WriteLine("All calculations are complete.");

            // Display the results.
            for (int i = 0; i < FibonacciCalculations; i++)
            {
                Fibonacci f = fibArray[i];
                Console.WriteLine("Fibonacci({0}) = {1}", f.N, f.FibOfN);
            }

            Console.ReadKey();
        }
    }
}
