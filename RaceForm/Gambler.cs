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
        public string naam { get; set; }
        public int cash { get; set; }

        public Gambler(string naam, int cash)
        {
            this.naam = naam;
            this.cash = cash;
        }

    
    }
}