using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadsMutex
{
    public class MyCounter
    {
        public static int count = 0;
        public static Mutex MuTexLock = new Mutex();
    }
}
