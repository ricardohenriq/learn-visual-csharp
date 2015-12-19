using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heranca
{
    public partial class ZooHome : Form
    {
        private Zoo zoo;

        public ZooHome()
        {
            zoo = new Zoo() {Name = "Zoologico"};
            InitializeComponent();
            createTypeEntityComboBox();
        }

        public void createTypeEntityComboBox()
        {
            typeEntityComboBox.Items.Add("Humano");
            typeEntityComboBox.Items.Add("Animal");
        }

        private void typeEntityComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (typeEntityComboBox.Text == "Humano")
            {
                MessageBox.Show("Humano");
            }
            else if (typeEntityComboBox.Text == "Animal")
            {
                MessageBox.Show("Animal");
            }
        }

        private void createHumanComponents()
        {
            TextBox function = new TextBox();
            function.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            function.Location = new System.Drawing.Point(119, 211);
            function.Name = "functionTextBox";
            function.Size = new System.Drawing.Size(121, 20);
            function.TabIndex = 16;

            this.Controls.Add(function);
        }

        private void createAnimalComponents()
        {
            TextBox origin = new TextBox();
            origin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            origin.Location = new System.Drawing.Point(119, 119);
            origin.Name = "originTextBox";
            origin.Size = new System.Drawing.Size(121, 20);
            origin.TabIndex = 14;

            TextBox specie = new TextBox();
            specie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            specie.Location = new System.Drawing.Point(119, 86);
            specie.Name = "specieTextBox";
            specie.Size = new System.Drawing.Size(121, 20);
            specie.TabIndex = 13;

            this.Controls.Add(specie);
            this.Controls.Add(origin);
        }

        private void singUpButton_Click(object sender, EventArgs e)
        {
            if (typeEntityComboBox.Text == "Humano")
            {
                singUpHuman();
            }
            else if (typeEntityComboBox.Text == "Animal")
            {
                singUpAnimal();
            }
        }

        public void singUpHuman()
        {
            Human human = new Human() {
                function = functionTextBox.Text,
                id = idTextBox.Text,
                borndate = borndateDateTimePicker.Value
            };
            zoo.Entities.Add(human);
            MessageBox.Show(human.ToString());
        }

        public void singUpAnimal()
        {
            Animal animal = new Animal() {
                specie = specieTextBox.Text,
                origin = originTextBox.Text,
                id = idTextBox.Text,
                borndate = borndateDateTimePicker.Value
            };
            zoo.Entities.Add(animal);
            MessageBox.Show(animal.ToString());
        }
    }
}
