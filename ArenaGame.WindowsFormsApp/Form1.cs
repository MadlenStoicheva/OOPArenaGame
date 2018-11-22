using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArenaGame.WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Play_Click(object sender, EventArgs e)
        {
            var firstCheckedButton = groupBoxHeroOne.Controls.OfType<RadioButton>()
                                 .FirstOrDefault(r => r.Checked);

            var secondCheckedButton = groupBoxHeroTwo.Controls.OfType<RadioButton>()
                                   .FirstOrDefault(r => r.Checked);
            
            if (firstCheckedButton == null)
            {
                MessageBox.Show("You didn't choose hero one!");
                return;
            }
            else if (secondCheckedButton == null)
            {
                MessageBox.Show("You didn't choose hero two!");
                return;
            }

            Hero choosenOne = ChosenHero(firstCheckedButton.AccessibleName);
            Hero choosenSecond = ChosenHero(secondCheckedButton.AccessibleName);

            Form2 form2 = new Form2(choosenOne, choosenSecond);

            this.Hide();
            form2.ShowDialog();

        }

        private Hero ChosenHero(string choosenHero)
        {
            switch (choosenHero)
            {
                case "Knight":
                    return new Knight();
                case "Assassian":
                    return new Assassian();
                case "Dwarf":
                    return new Dwarf();
                case "Monk":
                    return new Monk();
                case "Warrior":
                    return new Warrior();
                default:
                    return null;
            }
        }
    }
}
