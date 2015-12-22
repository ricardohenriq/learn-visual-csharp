using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadsMutex
{
    public class DecThread
    {
        public Thread th;
        public DecThread()
        {
            th = new Thread(new ThreadStart(this.Go));
            th.Start();
        }
        void Go()
        {
            Console.WriteLine("DecThread is waiting for the mutex.");
            MyCounter.MuTexLock.WaitOne();
            Console.WriteLine("DecThread acquires the mutex.");
            int num = 10;
            do
            {
                Thread.Sleep(50);
                MyCounter.count--;
                Console.WriteLine("In DecThread, MyCounter.count is " + MyCounter.count);
                num--;
            } while (num > 0);
            Console.WriteLine("DecThread releases the mutex.");
            MyCounter.MuTexLock.ReleaseMutex();
        }
    }
}
