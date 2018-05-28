﻿using System;
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
        Horses[] horses = new Horses[4];
        Gambler[] gamblers = new Gambler[3];
        public Form1()
        {
            InitializeComponent();

            
        }

        public void SetupRaceTrack()
        {
            horses[1] = new Horses()
            {
                

            };

            gamblers[0] = new Gambler("Ketty", new Game(), 10, new Label());
            gamblers[1] = new Gambler("Mark", new Game(), 50, new Label());
            gamblers[2] = new Gambler("Harald", new Game(), 100, new Label());

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string betAmountMark = textBox2.Text;    //1.Haal de ingevulde waarde van Mark op en sla die op in een veldje
            string betAmountHarald = textBox3.Text;  //2.Haal de ingevulde waarde van Harald op en sla die op in een veldje
            string betAmountKetty = textBox4.Text;   //3.Haal de ingevulde waarde van Ketty op en sla die op in een veldje

            string bets = "Mark has bet: " + betAmountMark +"\r\n" + "Harald has bet: " + betAmountHarald + "\r\n" + 
                          "Ketty has bet: " + betAmountKetty;                   //4.Maak een string van al die waardes

            string[] randomNumbers = new string[] { Paardje1Textbox.Text, Paardje2Textbox.Text, Paardje3Textbox.Text, Paardje4Textbox.Text };

            //Label[] horses = { Paardje1, Paardje2, Paardje3, Paardje4 }; <-- hoeft waarschijnlijk niet, want we doen niks met de labels

            //Hier ergens moet nog code komen waarin random nummers worden gegenereerd voor de textboxen van horses
            //zodra je op 'Start Race' drukt.

            try
            {
                int betMark = Int32.Parse(betAmountMark);                                           //Parse string textboxes to int with parse method
                int betHarald = Int32.Parse(betAmountHarald);
                int betKetty = Int32.Parse(betAmountKetty);

                int totalBets = betMark + betHarald + betKetty;

                int[] myHorsesNumbers = Array.ConvertAll(randomNumbers, s => int.Parse(s));         //convert string array to int array
          
                LogMessage(bets);                                                                   //5.Log de string
                LogMessage(totalBets.ToString());
                LogMessage(myHorsesNumbers.ToString());
            }
            catch (Exception)
            {
                throw new Exception("Place a valid bet");
            }
        }

        private void LogMessage(string msg)
        {
            //Dit is onze log code, deze methode hoef je nooit meer aan te passen
            this.Invoke(new Action(() => textBox1.Text += msg + "\r\n"));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Paardje1Textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
