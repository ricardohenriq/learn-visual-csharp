using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadsSincronizacao
{
    public class CellCons
    {
        //Instancia de Cell (esta instancia é a mesma de CellProd)
        Cell cell;
        //Quantos itens serão poduzidos pela cell
        int quantity = 1;

        public CellCons(Cell box, int request)
        {
            cell = box;
            quantity = request;
        }

        //Este é o método que foi passado no construtor da Thread
        public void ThreadRun()
        {
            int valReturned;
            for (int looper = 1; looper <= quantity; looper++)
            {
                //Irá chamar o método que irá produzir
                valReturned = cell.ReadFromCell();
            }
        }
    }
}
