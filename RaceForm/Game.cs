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
            Run();

            var horses = new List<int>();
            horses.Add();
            horses.Add(2);
            horses.Add(3);
            horses.Add(4);
        }
        public void PlaceBet(string nameOfBetter, int amount, int horse)
        {
            var gambler = ZoekGambler(nameOfBetter);
            var minBet = MinBet;

            if(gambler == null)
            {
                throw new Exception("No better!");
            }

            if(gambler.Cash >= amount)      //als gambler zijn cash meer is dan amount 0.
            {
                if (horse != 0)
                {
                    var myBet = new Bet();
                }//kijk of paard bestaat en of er genoeg cash is etc.
            }
            
        }
        public void addGambler(string naam, int cash)
        {
          if(naam!=null && cash > Amount)         //Als een naam bestaat en de cash minder dan de (minimale bet) is.
            {
                List<Gambler> gambler = new List<Gambler>();   //Als dat zo is, maak dan een lijst aan met gamblers.
                gambler.Add(new Gambler("Ketty", 10));         //En geef een naam op met hoeveel cash hij/zij heeft

            }
            else
            {
                throw new Exception("There is no gambler");
            }

        }
        private Gambler ZoekGambler(string name)
        {
            foreach (var gambler in Gamblers)
            {
                if (gambler.Name == name)
                {
                    return gambler;
                }
            }
            return null;
        }

        public bool Run()
        {
            
            return true;
        }
        public void Reset()
        {
         
            
          //Als de finish is
          //Of als de cashout gedaan is
        }
       
    }
}
