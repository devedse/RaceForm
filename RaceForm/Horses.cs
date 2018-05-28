using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceForm
{
    class Horses
    {
        public int Location = 0;
        public int Racetrack = 100;
        public int StartingPosition = 0;
        public Random Randomizer;
        
        
        public bool Run()
        {
            Randomizer = new Random();
            int distance = Randomizer.Next(1, 100);

            Location += distance;

            if (Location >= (Racetrack - StartingPosition))
            {
                return true;
            }
            return false;
        }

        public void TakeStartPosition()
        {
            Location = 0;
        }
    }
}
