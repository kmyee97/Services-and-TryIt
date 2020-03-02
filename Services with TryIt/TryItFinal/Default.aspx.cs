using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TryItFinal
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void getQuote(object sender, EventArgs e)
        {
            if (TextBox2.Text == "")
            {
                Label2.Text = "Please enter the correct inputs";
            }
            else
            {
                //get the service
                gettingQuote.Service1Client gettingInfo = new gettingQuote.Service1Client();
                //get the inputs from user
                string sym = TextBox2.Text;
                string newString1 = "";
                string newString2 = "";
                //call the method from the service
                newString1 = gettingInfo.Stockquote(sym);
                newString2 = gettingInfo.Stocknews(sym);
                //show the answer
                Label2.Text = newString1;
                Label3.Text = newString2;
            }
        }
        protected void ConvertToNewCurrency(object sender, EventArgs e)
        {

            //double newMoney;
            Uri baseUri = new Uri("http://webstrar34.fulton.asu.edu/Page1/Service1.svc");
            UriTemplate myTemp = new UriTemplate("moneyConvert?value={value}&currency1={currency1}&currency2={currency2}");
            Uri completeUri = myTemp.BindByPosition(baseUri, TextBox1.Text, DropDownList1.Text, DropDownList2.Text);
            WebClient channel = new WebClient();
            byte[] abc = channel.DownloadData(completeUri);
            Stream strm = new MemoryStream(abc);
            DataContractSerializer obj = new DataContractSerializer(typeof(double));
            double newMoney = (double)obj.ReadObject(strm);
            //newMoney = conversion.moneyConvert(money, currency1, currency2);
            //label1.Text = newMoney.ToString();
            output.Text = ("The value is " + newMoney.ToString());

        }
        protected void WordFilter(object sender, EventArgs e)
        {

            //get the service
            WordFilterService.Service1Client filtering = new WordFilterService.Service1Client();
            string newString = "";
            //get the input from user
            string input = TextBox3.Text;
            //call the service method
            newString = filtering.WordFilter(input);
            //show the output
            Label1.Text = newString;

        }
        protected void findNearestStore(object sender, EventArgs e)
        {
            if (TextBox4.Text == "" || TextBox5.Text == "")
            {
                Label4.Text = "Please enter the correct inputs";
            }
            else
            {
                //get the service
                nearestStore.Service1Client foundTheStore = new nearestStore.Service1Client();
                //get the inputs from user
                string zip = TextBox4.Text;
                string name = TextBox5.Text;
                string newString = "";
                //call the method from the service
                newString = foundTheStore.findNearestStore(zip, name);
                //show the answer
                Label4.Text = newString;
            }
        }
    }
}