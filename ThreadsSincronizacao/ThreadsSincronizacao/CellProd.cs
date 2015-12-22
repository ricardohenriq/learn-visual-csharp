﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadsSincronizacao
{
    public class CellProd
    {
        Cell cell;         // Field to hold cell object to be used
        int quantity = 1;  // Field for how many items to produce in cell

        public CellProd(Cell box, int request)
        {
            cell = box;          // Pass in what cell object to be used
            quantity = request;  // Pass in how many items to produce in cell
        }
        public void ThreadRun()
        {
            for (int looper = 1; looper <= quantity; looper++)
                cell.WriteToCell(looper);  // "producing"
        }
    }
}
