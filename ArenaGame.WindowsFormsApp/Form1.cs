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

        private void button1_Click(object sender, EventArgs e)
        {
            var firstCheckedButton = groupBoxHeroOne.Controls.OfType<RadioButton>()
                                 .FirstOrDefault(r => r.Checked);

            var secondCheckedButton = groupBoxHeroTwo.Controls.OfType<RadioButton>()
                                   .FirstOrDefault(r => r.Checked);

            if (firstCheckedButton == null && secondCheckedButton == null)
            {
                throw new ArgumentException("You didn't choose heroes!");
                //MessageBox.Show("You didn't choose heroes!");
            }
            else
            if (firstCheckedButton == null)
            {
                 throw new ArgumentException("You didn't choose hero one!");
                //MessageBox.Show("You didn't choose hero one!");
            }
            else
            if (secondCheckedButton == null)
            {
                throw new ArgumentException("You didn't choose hero two!");
                //MessageBox.Show("You didn't choose hero two!");
            }

            Hero choosenOne = ChoosenHero(firstCheckedButton.AccessibleName);
            Hero choosenSecond = ChoosenHero(secondCheckedButton.AccessibleName);

            Form2 form2 = new Form2();
            GameEngine game = new GameEngine();
            Print print = new Print(form2);

            game.PlayArena(choosenOne, choosenSecond, print);

            this.Hide();
            form2.ShowDialog();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private Hero ChoosenHero(string choosenHero)
        {
            if (choosenHero == "Knight")
            {
                Knight knightHeroOne = new Knight();
                return knightHeroOne;
            }

            if (choosenHero == "Assassian")
            {
                Assassian assassianHeroOne = new Assassian();
                return assassianHeroOne;
            }

            if (choosenHero == "Dwarf")
            {
                Dwarf dwarfHeroOne = new Dwarf();
                return dwarfHeroOne;
            }
            if (choosenHero == "Monk")
            {
                Monk monkHeroOne = new Monk();
                return monkHeroOne;
            }

            if (choosenHero == "Warrior")
            {
                Warrior warriorHeroOne = new Warrior();
                return warriorHeroOne;
            }

            return null;
            
        }
    }
}
