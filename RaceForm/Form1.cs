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
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string betAmountMark = textBox2.Text;    //1.Haal de ingevulde waarde van Mark op en sla die op in een veldje
            string betAmountHarald = textBox3.Text;  //2.Haal de ingevulde waarde van Harald op en sla die op in een veldje
            string betAmountKetty = textBox4.Text;   //3.Haal de ingevulde waarde van Ketty op en sla die op in een veldje

            string bets = betAmountMark + betAmountHarald + betAmountKetty;  //4.Maak een string van al die waardes

            LogMessage(bets);
            //5.Log de string

        }


        private void LogMessage(string msg)
        {
            //Dit is onze log code, deze methode hoef je nooit meer aan te passen
            this.Invoke(new Action(() => textBox1.Text += msg + "\r\n"));
        }
    }
}
