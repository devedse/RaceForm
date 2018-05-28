using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceForm
{
    class Gambler
    {
        public int Cash;

        public string Name { get; set; }

        public Label MyLabel { get; }

        public Gambler(string name, Game myBet, int cash, Label myLabel)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("Give me a valid name");
            }

            MyLabel = myLabel;
            myLabel.Text = name;

            Cash = cash;
            
        }
    }
}
