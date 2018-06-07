using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceForm
{
    public class Game
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
            Horses = new List<Horse>();

            for (int i = 0; i < amountOfHorses; i++)
            {
                Horses.Add(new Horse("Huppelpaard", this));
            }
        }

        public void PlaceBet(string nameOfBetter, int amount, int horse)
        {
            var gambler = ZoekGambler(nameOfBetter);
            var minBet = MinBet;

            if (gambler == null)
            {
                throw new Exception("No better!");
            }

            if (gambler.Cash >= amount)      //als gambler zijn cash meer is dan amount 0.
            {
                if (horse != 0)
                {
                    var myBet = new Bet();
                }//kijk of paard bestaat en of er genoeg cash is etc.
            }

        }
        public void addGambler(string naam, int cash)
        {
            if (naam != null && cash > Amount)         //Als een naam bestaat en de cash minder dan de (minimale bet) is.
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
            //Laat dit nog maar even staan zoals het stond
            //Maar in elk geval goed om te noteren dat we een Nullreferenceexception kregen
            //Waaorm kregen we die?:
            //gambler was null zag ik
            //Gambler of Gamblers?/gamblers
            //klopt, maar dat fixen we later welok
            //Ok 
            //Even naar boven in deze klasse
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
            Random random = new Random();
            int distance = random.Next(1, 100);

            return true;
        }
        public void Reset()
        {

            //Als de finish is
            //Of als de cashout gedaan is
        }

    }
}
