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

            //Em Java as classes que irão usar threads devem extender/implementar 
            //uma classe/interface própria em C# deve-se passar o método.
            //Cria-se um objeto da classe Thread passando um método que será paralelizado, 
            //neste caso "Alpha.Beta()"
            Thread thread = new Thread(new ThreadStart(alpha.Beta));

            //Inicia a Thread
            thread.Start();

            //IsAlive: true Se esse thread tiver sido iniciado e não foi encerrado normalmente 
            //ou anulada; Caso contrário, false.
            //Espera até que a thread seja iniacializada (apesar de "thread.Start();" iniciar 
            //a thread isso não garante que a thread tomou o controle da CPU alguma vez).
            while (!thread.IsAlive);

            //Põe a Thread corrente (no caso a thread principal Program.cs) em espera por 
            //1 milisegundo liberando o processador para outra Thread assumir o controle
            Thread.Sleep(1);

            //Requisita que a thread pare a sua execução (isso não garante que ela pare é só um pedido, 
            //ela pode estar executando uma operação atomica no momento por exemplo)
            thread.Abort();

            // faz com que outras threads espere por ela até que ela acabe sua execução.
            thread.Join();

            Console.WriteLine();
            Console.WriteLine("Alpha.Beta has finished");

            try
            {
                Console.WriteLine("Try to restart the Alpha.Beta thread");
                //Impossível uma vez que a thread foi abortada ela não pode ser reiniciada
                thread.Start();
            }
            catch (ThreadStateException)
            {
                Console.Write("ThreadStateException trying to restart Alpha.Beta. ");
                Console.WriteLine("Expected since aborted threads cannot be restarted.");
            }

            //Mantém o console aberto até que alguma tecla seja acionada
            Console.ReadKey();
            return 0;
        }
    }
}
