using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceForm
{
    class Horses
    {
        public int Location = 0;
        public int StartingPosition { get; set; }
        public Random Randomizer { get; set; }

        int Racetrack = 100;
        
        public bool Run()
        {
            Random myRandom = new Random();
            int distance = myRandom.Next(1, 100);

            if (distance == 100)
            {
                return true;
            }

            return false;
        }

        public void TakeStartPosition()
        {
            
        }
    }
}
