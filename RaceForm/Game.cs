using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceForm
{
    class Game
    {
        public int Amount { get; set; }
        public Gambler Gamblers { get; set; }
        public int Horses { get; set; }
        public int HorsesAmount { get; set; }
        public int Bets { get; set; }
        public int Racetrack { get; set; }
        public int MinBet { get; set; }
        public int MaxBet { get; set; }
        
        Game(int HorsesAmount)
        {
            string[] horses = new string[3];
            horses[0] = "horse1";
            horses[1] = "horse2";
            horses[2] = "horse3";
            horses[3] = "horse4";
        }
        public bool PlaceBet(int HorseAmount, int Dog)
        {

        }
        public string AddGambler()
        {

        }

        public bool Run()
        {

        }
        public void Reset()
        {

        }
       
    }
}
