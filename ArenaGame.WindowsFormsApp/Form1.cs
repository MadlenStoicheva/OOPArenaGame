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

            comboBoxHeroOne.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxHeroOne.Items.Add(new Knight());
            comboBoxHeroOne.Items.Add(new Assassian());
            comboBoxHeroOne.Items.Add(new Dwarf());
            comboBoxHeroOne.Items.Add(new Monk());
            comboBoxHeroOne.Items.Add(new Warrior());

            comboBoxHeroTwo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxHeroTwo.Items.Add(new Knight());
            comboBoxHeroTwo.Items.Add(new Assassian());
            comboBoxHeroTwo.Items.Add(new Dwarf());
            comboBoxHeroTwo.Items.Add(new Monk());
            comboBoxHeroTwo.Items.Add(new Warrior());

        }

        private void button_Play_Click(object sender, EventArgs e)
        {
            if (comboBoxHeroOne.SelectedItem == null || comboBoxHeroTwo.SelectedItem==null)
            {
                MessageBox.Show("You didn't choose heroe!");
                return;
            }

            var firstComboHero = (Hero)comboBoxHeroOne.SelectedItem;

            var secondComboHero = (Hero)comboBoxHeroTwo.SelectedItem;

            Form2 form2 = new Form2(firstComboHero, secondComboHero);

            this.Hide();
            form2.ShowDialog();
            this.Show();
        }
    }
}
