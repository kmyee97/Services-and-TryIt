using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace moneyconversionApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            moneyConvert.Service1Client conversion = new moneyConvert.Service1Client();
            string currency1 = comboBox1.Text;
            string currency2 = comboBox2.Text;
            if (textBox1.Text == "")
            {
                label1.Text = "Please input a value";
            }
            else
            {
                double money = Convert.ToDouble(textBox1.Text);

                if (comboBox1.Text == "" || comboBox2.Text == "")
                {
                    label1.Text = "Please select a currency";
                }
                else
                {
                    //double newMoney;
                    Uri baseUri = new Uri("http://localhost:52073/Service1.svc/");
                    UriTemplate myTemp = new UriTemplate("moneyConvert?value={value}&currency1={currency1}&currency2={currency2}");
                    Uri completeUri = myTemp.BindByPosition(baseUri, money.ToString(), currency1, currency2);
                    WebClient channel = new WebClient();
                    byte[] abc = channel.DownloadData(completeUri);
                    Stream strm = new MemoryStream(abc);
                    DataContractSerializer obj = new DataContractSerializer(typeof(double));
                    double newMoney = (double)obj.ReadObject(strm);
                    //newMoney = conversion.moneyConvert(money, currency1, currency2);
                    //label1.Text = newMoney.ToString();
                    label1.Text = newMoney.ToString();
                }
            }
        }
    }
}
