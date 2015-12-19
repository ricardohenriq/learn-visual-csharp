using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListasArrays
{
    public partial class Form1 : Form
    {
        /*
            Collections and Data Structures
            -------------------------------
            Hashtable
            List
            Array
            Queue
            Stack
            LinkedList
            SortedList
            HashSet
            SortedSet
        */

        public Form1()
        {
            InitializeComponent();
        }

        private void listButton_Click(object sender, EventArgs e)
        {
            List<Double> doubleList = new List<Double>();

            doubleList.Add(2.9);
            doubleList.Add(12.9);
            doubleList.Add(34.7);

            string result = "";

            foreach (Double doubleValue in doubleList)
            {
                result += doubleValue + "\n";
            }

            MessageBox.Show(result);
        }

        private void arrayButton_Click(object sender, EventArgs e)
        {
            double[] doubleArray = new double[3];

            doubleArray[0] = 2.9;
            doubleArray[1] = 12.9;
            doubleArray[2] = 34.7;

            string result = "";

            for (int i = 0; i < doubleArray.Length; i++)
            {
                result += doubleArray[i] + "\n";
            }

            MessageBox.Show(result);
        }

        private void hashTableButton_Click(object sender, EventArgs e)
        {
            Hashtable contasHashtable = new Hashtable();

            contasHashtable.Add("Água", "R$ 100.00");
            contasHashtable.Add("Luz", "€ 200.00");
            contasHashtable.Add("Telefone", "US$ 150.00");

            string result = "";

            foreach (DictionaryEntry item in contasHashtable)
            {
                result += item.Key + " - " + item.Value + "\n";
            }

            MessageBox.Show(result);
        }
    }
}
