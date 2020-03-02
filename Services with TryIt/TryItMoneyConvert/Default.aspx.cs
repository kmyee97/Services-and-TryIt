using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TryItMoneyConvert
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ConvertToNewCurrency(object sender, EventArgs e)
        {
            
            //get the service
            MoneyConversion.Service1Client converting = new MoneyConversion.Service1Client();
            //get the inputs from user
            string currency1 = DropDownList1.Text;
            string currency2 = DropDownList2.Text;
            double money = Convert.ToDouble(TextBox1.Text);
            //call the method from the service
            double newMoney;
            newMoney = converting.moneyConvert(money, currency1, currency2);
            //show the answer
            output.Text = ("The value is " + newMoney.ToString());
            
        }
    }
}