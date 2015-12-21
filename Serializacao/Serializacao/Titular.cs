using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Serializacao
{
    public class Titular
    {
        [XmlElement("NomeCompleto")]
        public string Name;
        public DateTime Birthdate;

        public Titular(string name, DateTime birthdate)
        {
            this.Name = name;
            this.Birthdate = birthdate;
        }

        private Titular()
        {
            //Existe para prevenir a seguinte exception
            //Unhandled Exception: System.InvalidOperationException: CLASSE cannot 
            //be serialized because it does not have a parameterless constructor.
        }
    }
}
