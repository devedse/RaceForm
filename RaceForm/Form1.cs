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
            LogMessage("DOEI!");
        }

        private void LogMessage(string msg)
        {
            this.Invoke(new Action(() => textBox1.Text += msg + "\r\n"));
            this.Invoke(new Action(() => textBox2.Text += msg + "\r\n"));
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
