using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceForm
{
    class Horse
    {
        private string horse;

        public Horse(string horse)
        {
            this.horse = horse;
        }

        public string Game { get; set; }
        public Random Speed { get; set; }
        public int StartPosition { get; set; }
        
        //public bool Run()
        //{ 

        //}

        public void TakeStartPosition()
        {
            StartPosition = 0;
        }
    }
}
