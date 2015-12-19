using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Human : Entity, IEntity
    {
        public string function { get; set; }

        public int getAge()
        {
            return 1;
        }

        public override string ToString()
        {
            return "Função: " + this.function + "\n" +
                "Id: " + this.id;
        }
    }
}
