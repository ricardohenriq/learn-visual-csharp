using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    class User
    {
        public string name { get; set; }
        public int age { get; set; }

        public override string ToString()
        {
            return "Nome: " + name + "\nIdade: " + age;
        }
    }
}
