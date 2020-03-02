using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TryItStock
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void getQuote(object sender, EventArgs e)
        {
            if (TextBox.Text == "")
            {
                output.Text = "Please enter the correct inputs";
            }
            else
            {
                //get the service
                gettingQuote.Service1Client gettingInfo = new gettingQuote.Service1Client();
                //get the inputs from user
                string sym = TextBox.Text;
                string newString1 = "";
                string newString2 = "";
                //call the method from the service
                newString1 = gettingInfo.Stockquote(sym);
                newString2 = gettingInfo.Stocknews(sym);
                //show the answer
                output.Text = newString1;
                output2.Text = newString2;
            }
        }
    }
}