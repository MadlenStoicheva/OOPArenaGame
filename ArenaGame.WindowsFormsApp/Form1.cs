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
            List<Hero> heroes = new List<Hero>();

            bool isHeroOneRadioButtonChecked = false;
            foreach (RadioButton rdo in groupBoxHeroOne.Controls.OfType<RadioButton>())
            {
                if (rdo.Checked)
                {
                    isHeroOneRadioButtonChecked = true;

                    break;
                }
            }
            if (isHeroOneRadioButtonChecked)
            {
                if (radioHeroOneKnight.Checked)
                {
                    Knight knightHeroOne = new Knight();
                    heroes.Add(knightHeroOne);
                }
                else if (radioHeroOneAssassian.Checked)
                {
                    Assassian assassianHeroOne = new Assassian();
                    heroes.Add(assassianHeroOne);
                }
                else if (radioHeroOneDwarf.Checked)
                {
                    Dwarf dwarfHeroOne = new Dwarf();
                    heroes.Add(dwarfHeroOne);
                }
                else if (radioHeroOneMonk.Checked)
                {
                    Monk monkHeroOne = new Monk();
                    heroes.Add(monkHeroOne);
                }
                else if (radioHeroOneWarrior.Checked)
                {
                    Warrior warriorHeroOne = new Warrior();
                    heroes.Add(warriorHeroOne);
                }
            }
            else
            {
                MessageBox.Show("You didn't choose hero one!");
                isHeroOneRadioButtonChecked = false;
            }

            bool isHeroTwoRadioButtonChecked = false;
            foreach (RadioButton rdo in groupBoxHeroOne.Controls.OfType<RadioButton>())
            {
                if (rdo.Checked)
                {
                    isHeroTwoRadioButtonChecked = true;

                    break;
                }
            }
            if (isHeroTwoRadioButtonChecked)
            {
                if (radioHeroTwoKnight.Checked)
                {
                    Knight knightHeroTwo = new Knight();
                    heroes.Add(knightHeroTwo);
                }
                else if (radioHeroTwoAssassian.Checked)
                {
                    Assassian assassianHeroTwo = new Assassian();
                    heroes.Add(assassianHeroTwo);
                }
                else if (radioHeroTwoDwarf.Checked)
                {
                    Dwarf dwarfHeroTwo = new Dwarf();
                    heroes.Add(dwarfHeroTwo);
                }
                else if (radioHeroTwoMonk.Checked)
                {
                    Monk monkHeroTwo = new Monk();
                    heroes.Add(monkHeroTwo);
                }
                else if (radioHeroTwoWarrior.Checked)
                {
                    Warrior warriorHeroTwo = new Warrior();
                    heroes.Add(warriorHeroTwo);
                }
            }
            else
            {
                MessageBox.Show("You didn't choose hero two!");
                isHeroTwoRadioButtonChecked = false;
            }

            Form2 form2 = new Form2();
            GameEngine game = new GameEngine();
            Print print = new Print(form2);

            game.PlayArena(heroes[0], heroes[1], print);

            this.Hide();
            form2.ShowDialog();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
