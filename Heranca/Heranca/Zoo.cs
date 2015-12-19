using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Zoo
    {
        public string Name { get; set; }
        public List<Entity> Entities;

        public Zoo()
        {
            Entities = new List<Entity>();
        }
    }
}
