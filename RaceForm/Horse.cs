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

        public Horse(string nameOfHorse)
        {
            this.horse = nameOfHorse;
        }

        public string Game { get; set; }
        public Random RandomSpeed { get; set; }
        public int StartPosition { get; set; }
        public int Location { get; set; }

        public bool Run()
        {
            Location += RandomSpeed.Next(1, 100);
            horse += Location;

            if(Location == 100)
            {
                return true;
            }
            return false;
        }

        public void TakeStartPosition()
        {
            Location =  0;
        }
    }
}
