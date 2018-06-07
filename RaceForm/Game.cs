using System;
using System.Collections.Generic;

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

        private ILogger logger;

        public Game(ILogger logger, int amountOfHorses)
        {
            this.logger = logger;

            Horses = new List<Horse>();
            Gamblers = new List<Gambler>();

            for (int i = 0; i < amountOfHorses; i++)
            {
                Horses.Add(new Horse("Huppelpaard" + i, this));
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

                    logger.LogMessage($"{nameOfBetter} has bet {amount} on horse {horse}");
                }
                //kijk of paard bestaat en of er genoeg cash is etc.
            }

        }
        public void addGambler(string naam, int cash)
        {
            if (naam != null && cash > Amount)         //Als een naam bestaat en de cash minder dan de (minimale bet) is.
            {
                Gamblers.Add(new Gambler(naam, cash));         //En geef een naam op met hoeveel cash hij/zij heef
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
