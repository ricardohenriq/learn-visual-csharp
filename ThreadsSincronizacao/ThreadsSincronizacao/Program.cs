using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadsSincronizacao
{
    public class Program
    {
        static void Main(string[] args)
        {
            int result = 0;//Irá armazenar os erros, se tiverem
            //A classe Cell é que possui os métodos de escrita e produção
            Cell cell = new Cell();

            //A classe CellProd é que irá fazer as chamadas ao metodo podutor de cell 
            //(no caso 20 cahamadas)
            CellProd prod = new CellProd(cell, 20);
            //A classe CellCons é que irá fazer as chamadas ao metodo consumidor de cell 
            //(no caso 20 cahamadas)
            CellCons cons = new CellCons(cell, 20);

            //Cria uma tread com o método que irá Consumir
            Thread producer = new Thread(new ThreadStart(prod.ThreadRun));
            //Cria uma tread com o método que irá Produzir
            Thread consumer = new Thread(new ThreadStart(cons.ThreadRun));

            try
            {
                //Inicia ambas as threads
                producer.Start();
                consumer.Start();

                //Pausa a thread corrente e aguarda ambas as threads terminarem suas execuções
                producer.Join();
                consumer.Join();
            }
            catch (ThreadStateException e)
            {
                Console.WriteLine(e);
                result = 1;
            }
            catch (ThreadInterruptedException e)
            {
                Console.WriteLine(e);
                result = 1;
            }

            Console.ReadKey();

            // Embora Main retorna void, isso fornece um código de retorno para o processo pai.
            Environment.ExitCode = result;
        }
    }
}
