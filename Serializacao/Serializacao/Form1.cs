using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Xml;
using System.Xml.Serialization;

namespace Serializacao
{
    public partial class serializacao : Form
    {
        public serializacao()
        {
            InitializeComponent();
        }

        private void toJSONButton_Click(object sender, EventArgs e)
        {
            List<ContaCorrente> contaCorrenteList = loadContaCorrente();

            string json = JsonConvert.SerializeObject(contaCorrenteList, Newtonsoft.Json.Formatting.Indented);

            StreamWriter escritor = null;
            try
            {
                string path = @"C:\Users\Ricardo\Documents\Visual Studio 2015\Projects\Serializacao\Serializacao\JSON.txt";
                if (!File.Exists(path))
                {
                    File.Create(path).Close();
                }
                escritor = new StreamWriter(path);
                escritor.WriteLine(json);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (escritor != null)
                {
                    escritor.Close();
                }
            }

            MessageBox.Show(json);
        }

        private void fromJSONButton_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\Ricardo\Documents\Visual Studio 2015\Projects\Serializacao\Serializacao\JSON.txt";
            string texto = "";
            if (File.Exists(path))
            {
                StreamReader leitor = new StreamReader(path);
                texto = leitor.ReadToEnd();
                leitor.Close();
            }

            List<ContaCorrente> contaCorrenteList  = JsonConvert.DeserializeObject<List<ContaCorrente>>(texto);

            MessageBox.Show(contaCorrenteList.Count.ToString());
        }

        private void toXMLButton_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\Ricardo\Documents\Visual Studio 2015\Projects\Serializacao\Serializacao\XML.txt";

            List<ContaCorrente> contaCorrenteList = loadContaCorrente();

            XmlSerializer serializer = new XmlSerializer(typeof(List<ContaCorrente>));
            using (TextWriter writer = new StreamWriter(path))
            {
                serializer.Serialize(writer, contaCorrenteList);
            }
        }

        private void FromXMLButton_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\Ricardo\Documents\Visual Studio 2015\Projects\Serializacao\Serializacao\XML.txt";
            XmlSerializer deserializer = new XmlSerializer(typeof(List<ContaCorrente>));
            TextReader reader = new StreamReader(path);
            List<ContaCorrente> contaCorrenteList = (List<ContaCorrente>)deserializer.Deserialize(reader);
            reader.Close();

            string result = "";
            foreach (ContaCorrente conta in contaCorrenteList)
            {
                result += conta.Titular.Name + " - " + conta.Saldo + "\n";
            }

            MessageBox.Show(result);
        }

        private List<ContaCorrente> loadContaCorrente()
        {
            List<ContaCorrente> contaCorrenteList = new List<ContaCorrente>();
            contaCorrenteList.Add(
                new ContaCorrente(
                    new Titular(
                        "Bill Gates", Convert.ToDateTime("25/12/2015")
                    ),
                    42325.1234
                )
            );
            contaCorrenteList.Add(
                new ContaCorrente(
                    new Titular(
                        "Steve Jobs", Convert.ToDateTime("25/12/2015")
                    ),
                    54656.67
                )
            );
            contaCorrenteList.Add(
                new ContaCorrente(
                    new Titular(
                        "Obama", Convert.ToDateTime("25/12/2015")
                    ),
                    123.2342
                )
            );

            return contaCorrenteList;
        }
    }
}
