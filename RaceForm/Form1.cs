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
    public partial class Form1 : Form, ILogger
    {
        public Game Game { get; set; }
        public int Dingetje { get; set; }

        public Form1()
        {
            InitializeComponent();
            Game = new Game(this, 4);

            Game.addGambler("Gokbeest", 144);
            Game.addGambler("Dave", 20);
            Game.addGambler("Ket", 321321132);
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        public void LogMessage(string msg)
        {
            //Dit is onze log code, deze methode hoef je nooit meer aan te passen
            this.Invoke(new Action(() => betInfoTextBox.Text += msg + "\r\n"));
        }

        private void addBetButton_Click(object sender, EventArgs e)
        {
            int horseBet;

            if (horse1Button.Checked == true)
            {
                horseBet = 1;
            }
            else if (horse2Button.Checked == true)
            {
                horseBet = 2;
            }
            else if (horse3Button.Checked == true)
            {
                horseBet = 3;
            }
            else
            {
                horseBet = 4;
            }

            //Zie deze: http://csharp.net-informations.com/gui/cs-radiobutton.htm


            //Ga eens debuggen weer dan kan ik het laten zien :)
            //ow had je het gezien eigenlijk
            //Ja het werkte toch ^^?jaa
            //Maar snap je dit tukje hierboven? ja dat is niet zo la //elk paard is gelinkt aan een intje
            //Ja en op deze manier kan je dus kijken welk paard je hebt geselecteerd Als ik na ga denken dan is dat altijd ingewikkelder dan de code zelf

            //Ik zou zo weer ff inchecken ^^
            int amountToBet = int.Parse(amountTextBox.Text);
            Game.PlaceBet(nameTextBox.Text, amountToBet, horseBet);
        }
    }
}
