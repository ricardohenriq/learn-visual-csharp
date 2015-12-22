using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadsMutex
{
    public class IncThread
    {
        public Thread th;
        public IncThread()
        {
            th = new Thread(this.Go);
            th.Start();
        }

        public void Go()
        {
            Console.WriteLine("IncThread is waiting for the mutex.");
            MyCounter.MuTexLock.WaitOne();
            Console.WriteLine("IncThread acquires the mutex.");
            int num = 10;
            do
            {
                Thread.Sleep(50);
                MyCounter.count++;
                Console.WriteLine("In IncThread, MyCounter.count is " + MyCounter.count);
                num--;
            } while (num > 0);
            Console.WriteLine("IncThread releases the mutex.");
            MyCounter.MuTexLock.ReleaseMutex();
        }
    }
}
