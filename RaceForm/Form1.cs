using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceForm
{

    public partial class Form1 : Form
    {
        public Game Game { get; set; }
        public int Dingetje { get; set; }

        public Form1()
        {
            InitializeComponent();
            Game = new Game(4);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void LogMessage(string msg)
        {
            //Dit is onze log code, deze methode hoef je nooit meer aan te passen
            this.Invoke(new Action(() => betInfoTextBox.Text += msg + "\r\n"));
        }

        private void addBetButton_Click(object sender, EventArgs e)
        {
            Game.PlaceBet("Kerel", 12, 3);
            //Ok nu F5 om weer ddoor te gaan en dan een bet placen dan komen we hier

            //LogMessage("${0} has bet on Horse {1} with an amount of {3}", nameOfBetter, numberOfHorse, amountOfBet);
        }
    }
}
