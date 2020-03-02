using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectiveService1App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            getQuote.Service1Client gettingQuote = new getQuote.Service1Client();
            string sym = textBox1.Text;
            string newString1 = "";
            string newString2 = "";
            newString1 = gettingQuote.Stockquote(sym);
            newString2 = gettingQuote.Stocknews(sym);
            label1.Text = newString1;
            label2.Text = newString2;
        }
    }
}
