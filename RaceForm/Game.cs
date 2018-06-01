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
        public List<Gambler> Gamblers { get; set; }
        public List<Horse> Horses { get; set; }
        public int HorsesAmount { get; set; }
        public int Bets { get; set; }
        public int Racetrack { get; set; }
        public int MinBet { get; set; }
        public int MaxBet { get; set; }
        public Game(int amountOfHorses)
        {
            List<Horse> horses = new List<Horse>();
            horses.Add(new Horse("Horse 1"));
            horses.Add(new Horse("Horse 2"));
            horses.Add(new Horse("Horse 3"));
            horses.Add(new Horse("Horse 4"));
        }
        public void PlaceBet(string nameOfBetter, int amount, int horse)
        {
            var gambler = ZoekGambler(nameOfBetter);

            if(gambler == null)
            {
                throw new Exception("No better!");
            }

            if(gambler.cash >= amount)
            {
                if (horse != 0)
                {
                    var newBet = new Bet();
                }//kijk of paard bestaat en of er genoeg cash is etc.
            }
            
        }
        public void addGambler(string naam, int cash)
        {
          if(cash > Amount)
            {
                List<Gambler> gambler = new List<Gambler>();
                gambler.Add(new Gambler("Ketty", 10));
            }
            else
            {
                throw new Exception("There is no gambler");
            }

        }
        private Gambler ZoekGambler(string naam)
        {
            foreach (var gambler in Gamblers)
            {
                if (gambler.naam == naam)
                {
                    return gambler;
                }
            }
            return null;
        }

        //public bool Run()
        //{

        //}
        public void Reset()
        {

        }
       
    }
}
