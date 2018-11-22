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
        private ListBox lstBox = new ListBox();

        public Print(ListBox lstBox)
        {
            this.lstBox = lstBox;
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
