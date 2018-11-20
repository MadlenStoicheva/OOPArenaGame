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

            //Hero choosenOne = ChosenHero(firstCheckedButton.AccessibleName);
            //Hero choosenSecond = ChosenHero(secondCheckedButton.AccessibleName);

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

        //private Hero ChosenHero(string choosenHero)
        //{
            //if (choosenHero == "Knight")
            //{
            //    Knight knightHero = new Knight();
            //    return knightHero;
            //}

        //    if (choosenHero == "Assassian")
        //    {
        //        Assassian assassianHero = new Assassian();
        //        return assassianHero;
        //    }

        //    if (choosenHero == "Dwarf")
        //    {
        //        Dwarf dwarfHero = new Dwarf();
        //        return dwarfHero;
        //    }
        //    if (choosenHero == "Monk")
        //    {
        //        Monk monkHero = new Monk();
        //        return monkHero;
        //    }

        //    if (choosenHero == "Warrior")
        //    {
        //        Warrior warriorHero = new Warrior();
        //        return warriorHero;
        //    }

        //    return null;
            
        //}
    }
}
