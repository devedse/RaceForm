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
            Game.addGambler("Gokbeest", 144);
            Game.addGambler("Dave", 20);
            Game.addGambler("Ket", 321321132);

            //Wat nu  handig is d
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
            int amountToBet = int.Parse(amountTextBox.Text);
            Game.PlaceBet(nameTextBox.Text, amountToBet, 3);
        }
    }
}
