using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// StopJoin.cs
using System.Threading;

namespace Threads
{
    public class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine("Thread Start/Stop/Join Sample");

            Alpha alpha = new Alpha();

            // Create the thread object, passing in the Alpha.Beta method
            // via a ThreadStart delegate. This does not start the thread.
            Thread thread = new Thread(new ThreadStart(alpha.Beta));

            // Start the thread
            thread.Start();

            // Spin for a while waiting for the started thread to become
            // alive:
            while (!thread.IsAlive) ;

            // Put the Main thread to sleep for 1 millisecond to allow thread
            // to do some work:
            Thread.Sleep(1);

            // Request that thread be stopped
            thread.Abort();

            // Wait until thread finishes. Join also has overloads
            // that take a millisecond interval or a TimeSpan object.
            thread.Join();

            Console.WriteLine();
            Console.WriteLine("Alpha.Beta has finished");

            try
            {
                Console.WriteLine("Try to restart the Alpha.Beta thread");
                thread.Start();
            }
            catch (ThreadStateException)
            {
                Console.Write("ThreadStateException trying to restart Alpha.Beta. ");
                Console.WriteLine("Expected since aborted threads cannot be restarted.");
            }

            Console.ReadKey();
            return 0;
        }
    }
}
