using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Entity
    {
        public string id { get; set; }
        public DateTime borndate;

        public DateTime getBorndate()
        {
            return this.borndate;
        }
    }
}
