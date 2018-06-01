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
        
        public Form1()
        {
            InitializeComponent();
     
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void LogMessage(string msg)
        {
            //Dit is onze log code, deze methode hoef je nooit meer aan te passen
            this.Invoke(new Action(() => betInfoTextBox.Text += msg + "\r\n"));
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void Paardje1Textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addBetButton_Click(object sender, EventArgs e)
        {
            //LogMessage("${0} has bet on Horse {1} with an amount of {3}", nameOfBetter, numberOfHorse, amountOfBet);
        }
    }
}
