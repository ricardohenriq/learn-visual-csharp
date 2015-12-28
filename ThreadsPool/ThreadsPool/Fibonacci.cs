using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadsPool
{
    public class Fibonacci
    {
        private int _n;
        private int _fibOfN;
        private ManualResetEvent _doneEvent;

        public int N { get { return _n; } }
        public int FibOfN { get { return _fibOfN; } }

        public Fibonacci(int n, ManualResetEvent doneEvent)
        {
            _n = n;
            //Armazena a referencia a instancia do objeto (implicitamente é passado somente 
            //um ponteiro)
            _doneEvent = doneEvent;
        }

        // Encapsula o método que será usado no ThreadPool.
        public void ThreadPoolCallback(Object threadContext)
        {
            int threadIndex = (int)threadContext;
            Console.WriteLine("thread {0} started...", threadIndex);
            _fibOfN = Calculate(_n);
            Console.WriteLine("thread {0} result calculated...", threadIndex);
            //Define o estado do evento para sinalizado, que permite que uma ou mais threads 
            //esperando possam prosseguir.
            _doneEvent.Set();
        }

        //Método recursivo que calcula o número N Fibonacci.
        public int Calculate(int n)
        {
            if (n <= 1)
            {
                return n;
            }

            return Calculate(n - 1) + Calculate(n - 2);
        }
    }
}
