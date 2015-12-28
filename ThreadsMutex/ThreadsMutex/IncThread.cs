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
            //Cria a Thread passando o proprio método
            th = new Thread(this.Go);
            //Inicializa a thread
            th.Start();
        }

        public void Go()
        {
            Console.WriteLine("IncThread is waiting for the mutex.");
            //Bloqueia o thread atual até o atual WaitHandle recebe um sinal.
            MyCounter.MuTexLock.WaitOne();
            //Se ninguem tiver obtido o Mutex ainda ou este tiver sido liberado a thread 
            //seguirá em frente
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
            //Libera o Mutex uma vez.
            MyCounter.MuTexLock.ReleaseMutex();
        }
    }
}
