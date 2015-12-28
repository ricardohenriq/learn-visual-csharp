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
            this.createTypeEntityComboBox();
            this.hideAnimalFields();
            this.hideHumanFields();
            this.hideCommomFields();
            
        }

        public void createTypeEntityComboBox()
        {
            typeEntityComboBox.Items.Add("Humano");
            typeEntityComboBox.Items.Add("Animal");
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

        public void hideAnimalFields()
        {
            specieLabel.Hide();
            specieTextBox.Hide();
            originLabel.Hide();
            originTextBox.Hide();
        }

        public void hideHumanFields()
        {
            functionLabel.Hide();
            functionTextBox.Hide();
        }

        public void hideCommomFields()
        {
            entityTypeLabel.Hide();
            typeComboBox.Hide();
            borndateLabel.Hide();
            borndateDateTimePicker.Hide();
            idLabel.Hide();
            idTextBox.Hide();
        }

        public void showHumanFields()
        {
            functionLabel.Show();
            functionTextBox.Show();
        }

        public void showAnimalFields()
        {
            specieLabel.Show();
            specieTextBox.Show();
            originLabel.Show();
            originTextBox.Show();
        }

        public void showCommomFields()
        {
            entityTypeLabel.Show();
            typeComboBox.Show();
            borndateLabel.Show();
            borndateDateTimePicker.Show();
            idLabel.Show();
            idTextBox.Show();
        }

        private void typeEntityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typeEntityComboBox.Text == "Humano")
            {
                this.hideAnimalFields();
                this.showHumanFields();
                this.showCommomFields();
            }
            else if (typeEntityComboBox.Text == "Animal")
            {
                this.hideHumanFields();
                this.showAnimalFields();
                this.showCommomFields();
            }
        }
    }
}
