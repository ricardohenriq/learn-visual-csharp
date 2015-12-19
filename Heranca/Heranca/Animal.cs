using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Animal : Entity, IEntity
    {
        public string specie { get; set; }
        public string origin { get; set; }

        public int getAge()
        {
            return 1;
        }

        public override string ToString()
        {
            return "Especie: " + this.specie + "\n" +
                "Origem: " + this.origin + "\n" +
                "Id: " + this.id;
        }
    }
}
