﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadsMutex
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IncThread myt1 = new IncThread();
            DecThread myt2 = new DecThread();
            //myt1.thrd.Join();
            //myt2.thrd.Join();
            Console.Read();
        }
    }
}