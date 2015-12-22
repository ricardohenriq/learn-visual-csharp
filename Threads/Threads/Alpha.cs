using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// StopJoin.cs
using System.Threading;

namespace Threads
{
    public class Alpha
    {
        // This method that will be called when the thread is started
        public void Beta()
        {
            while (true)
            {
                Console.WriteLine("Alpha.Beta is running in its own thread.");
            }
        }
    }
}
