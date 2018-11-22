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
    public partial class Form2 : Form
    {
        private Hero FirstHero { get; set; }
        private Hero SecondHero { get; set; }

        public Form2(Hero heroOne, Hero secondHero)
        {
            InitializeComponent();

            FirstHero = heroOne;
            SecondHero = secondHero;
            GameEngine game = new GameEngine();
            Print print = new Print(listBox_HeroesFight);
            game.PlayArena(FirstHero, SecondHero, print);
        }

        private void button_PlayAgain_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

    }
}
