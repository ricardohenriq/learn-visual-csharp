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
            //Cria a Thread passando o proprio método
            th = new Thread(new ThreadStart(this.Go));
            //Inicializa a thread
            th.Start();
        }

        void Go()
        {
            Console.WriteLine("DecThread is waiting for the mutex.");
            //Bloqueia o thread atual até o atual WaitHandle recebe um sinal.
            MyCounter.MuTexLock.WaitOne();
            //Se ninguem tiver obtido o Mutex ainda ou este tiver sido liberado a thread 
            //seguirá em frente
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
            //Libera o Mutex uma vez.
            MyCounter.MuTexLock.ReleaseMutex();
        }
    }
}
