using ArenaGame.Library.Engine.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArenaGame.WindowsFormsApp
{
    public class Print : IPrint
    {
        Form2 form2;
        private ListBox lstBox = new ListBox();

        public Print(Form2 form2)
        {
            this.form2 = form2;
            form2.Controls.Add(lstBox);
            this.lstBox.Location = new System.Drawing.Point(250, 85);
            this.lstBox.Size = new System.Drawing.Size(330, 195);
        }

        public void PrintIfHeroIsDead(string message)
        {
            this.lstBox.Items.Add(message);
        }

        public void PrintAttackDeffendingMechanism(string message)
        {
            this.lstBox.Items.Add(message);
        }
    }
}
