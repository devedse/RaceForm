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

          //  LogMessage();

            string betAmountMark = textBox2.Text;
            string betAmountHarald = textBox3.Text;
            string betAmountKetty = textBox4.Text;

            string bets = betAmountMark + betAmountHarald + betAmountKetty;
            //1.Haal de ingevulde waarde van Mark op en sla die op in een veldje

            //2.Haal de ingevulde waarde van ...

            //3.Haal de......

            //4.Maak een string van al die waardes

            //5.Log de string

        }

        private void LogMessage(string msg)
        {
            this.Invoke(new Action(() => textBox1.Text += msg + "\r\n"));
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
