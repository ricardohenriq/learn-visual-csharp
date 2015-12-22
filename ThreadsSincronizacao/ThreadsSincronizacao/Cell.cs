using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadsSincronizacao
{
    public class Cell
    {
        int cellContents;         // Cell contents
        bool readerFlag = false;  // State flag
        public int ReadFromCell()
        {
            lock (this)   // Enter synchronization block
            {
                if (!readerFlag)
                {            // Wait until Cell.WriteToCell is done producing
                    try
                    {
                        // Waits for the Monitor.Pulse in WriteToCell
                        //Libera o bloqueio em um objeto e bloqueia o thread 
                        //atual até que ele readquire o bloqueio.
                        //No caso o objeto é a própria instancia.
                        Monitor.Wait(this);
                    }
                    catch (SynchronizationLockException e)
                    {
                        Console.WriteLine(e);
                    }
                    catch (ThreadInterruptedException e)
                    {
                        Console.WriteLine(e);
                    }
                }
                Console.WriteLine("Consume: {0}", cellContents);
                readerFlag = false;    // Reset the state flag to say consuming
                                       // is done.
                Monitor.Pulse(this);   // Pulse tells Cell.WriteToCell that
                                       // Cell.ReadFromCell is done.
            }   // Exit synchronization block
            return cellContents;
        }

        public void WriteToCell(int n)
        {
            //Garante que um thread não entre em uma seção crítica 
            //do código enquanto outro thread está na seção crítica. 
            //(No caso esta mesma instancia de objeto "this") 
            //Se outro segmento tenta digitar um código bloqueado, esperará, 
            // para bloquear, até que o objeto seja liberado.
            lock (this)  // Enter synchronization block
            {
                if (readerFlag)
                {      // Wait until Cell.ReadFromCell is done consuming.
                    try
                    {
                        Monitor.Wait(this);   // Wait for the Monitor.Pulse in
                                              // ReadFromCell
                    }
                    catch (SynchronizationLockException e)
                    {
                        Console.WriteLine(e);
                    }
                    catch (ThreadInterruptedException e)
                    {
                        Console.WriteLine(e);
                    }
                }
                cellContents = n;
                Console.WriteLine("Produce: {0}", cellContents);
                readerFlag = true;    // Reset the state flag to say producing
                                      // is done
                //Notifica um thread na fila de espera de uma alteração no estado do objeto bloqueado.
                //No caso notifica a própria instancia.
                Monitor.Pulse(this);  // Pulse tells Cell.ReadFromCell that 
                                      // Cell.WriteToCell is done.
            }   // Exit synchronization block
        }
    }
}
