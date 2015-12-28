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
            //Numero de threads a serem criadas
            const int FibonacciCalculations = 10;

            //Um evento para cada Objeto Fibonacci, este evento será setado como false 
            //primeiramente e dentro do objeto será setado como true após o final da execução 
            //da thread
            ManualResetEvent[] doneEvents = new ManualResetEvent[FibonacciCalculations];

            //Cria um array de classe Fibonacci
            Fibonacci[] fibArray = new Fibonacci[FibonacciCalculations];
            Random r = new Random();

            Console.WriteLine("launching {0} tasks...", FibonacciCalculations);
            for (int i = 0; i < FibonacciCalculations; i++)
            {
                //Preenche cada posição do array com um objeto da classe ManualResetEvent setado como false
                doneEvents[i] = new ManualResetEvent(false);
                //Cria uma instancia de Fibonacci com um valor e um evento que será setado como true 
                //quando a thread se encerrar
                Fibonacci f = new Fibonacci(r.Next(20, 40), doneEvents[i]);
                fibArray[i] = f;
                //Adiciona o método "ThreadPoolCallback" do objeto da classe Fibonacci ao ThreadPool
                //o "i" será passado como parametro para o método "ThreadPoolCallback"
                ThreadPool.QueueUserWorkItem(f.ThreadPoolCallback, i);
            }

            //Aguarda todas as theads do pool finalizarem sua execução
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
