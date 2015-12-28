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
        //Conteudo da celula
        int cellContents;
        //Flag de estado de produção e consumo
        //false: Consumido pode Produzir mais
        //true: Produzido mas não Comsumido 
        bool readerFlag = false;
        public int ReadFromCell()
        {
            //Garante que uma thread não entre em uma seção crítica 
            //do código enquanto outro thread está na seção crítica. 
            //(No caso esta mesma instancia de objeto "this") 
            //Se outro segmento tenta digitar um código bloqueado, esperará, 
            // para bloquear, até que o objeto seja liberado.
            lock (this)
            {
                if (!readerFlag)
                {            //Espera até Cell.WriteToCell produzir
                    try
                    {
                        //Aguarda o Monitor.Pulse em WriteToCell
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
                //Reseta o estado para Consumido pode Produzir mais
                readerFlag = false;
                //Pulse diz a Cell.WriteToCell que o método Cell.ReadFromCell esta concluido
                Monitor.Pulse(this);
            }
            return cellContents;
        }

        public void WriteToCell(int n)
        {
            //Garante que uma thread não entre em uma seção crítica 
            //do código enquanto outro thread está na seção crítica. 
            //(No caso esta mesma instancia de objeto "this") 
            //Se outro segmento tenta digitar um código bloqueado, esperará, 
            // para bloquear, até que o objeto seja liberado.
            lock (this)
            {
                if (readerFlag)
                {      //Espera até Cell.ReadToCell consumir
                    try
                    {
                        //Aguarda o Monitor.Pulse em ReadFromCell
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
                cellContents = n;
                Console.WriteLine("Produce: {0}", cellContents);
                //Reseta o estado para Produzido mas não Comsumido
                readerFlag = true;
                //Notifica um thread na fila de espera de uma alteração no estado do objeto bloqueado.
                //No caso notifica a própria instancia.
                //Pulse diz a Cell.ReadToCell que o método Cell.WriteFromCell esta concluido
                Monitor.Pulse(this);
            }
        }
    }
}
