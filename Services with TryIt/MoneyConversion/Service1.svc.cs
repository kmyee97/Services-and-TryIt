using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MoneyConversion
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public double moneyConvert(double value, string currency1, string currency2)
        {
           
            double temp = 0;
            switch (currency1)
            {
                case "USD": //converting from USD to another currency
                    if (currency2 == "USD")
                    {
                        temp = 1;
                        value = value * temp;
                    }
                    else if (currency2 == "EUR")
                    {
                        temp = .84;
                        value = value * temp;
                    }
                    else if (currency2 == "YEN")
                    {
                        temp = 112.35;
                        value = value * temp;
                    }
                    else if (currency2 == "CAN")
                    {
                        temp = 1.23;
                        value = value * temp;
                    }
                    else if (currency2 == "GBP")
                    {
                        temp = .74;
                        value = value * temp;
                    }
                    else if (currency2 == "CNY")
                    {
                        temp = 6.59;
                        value = value * temp;
                    }
                    break;
                case "EUR": //converting from EUR to another currency
                    if (currency2 == "USD")
                    {
                        temp = 1.11;
                        value = value * temp;
                    }
                    else if (currency2 == "EUR")
                    {
                        temp = 1;
                        value = value * temp;
                    }
                    else if (currency2 == "YEN")
                    {
                        temp = 120.93;
                        value = value * temp;
                    }
                    else if (currency2 == "CAN")
                    {
                        temp = 1.46;
                        value = value * temp;
                    }
                    else if (currency2 == "GBP")
                    {
                        temp = .86;
                        value = value * temp;
                    }
                    else if (currency2 == "CNY")
                    {
                        temp = 7.87;
                        value = value * temp;
                    }
                    break;
                case "YEN": //converting from YEN to another currency
                    if (currency2 == "USD")
                    {
                        temp = .0092;
                        value = value * temp;
                    }
                    else if (currency2 == "EUR")
                    {
                        temp = .0083;
                        value = value * temp;
                    }
                    else if (currency2 == "YEN")
                    {
                        temp = 1;
                        value = value * temp;
                    }
                    else if (currency2 == "CAN")
                    {
                        temp = .012;
                        value = value * temp;
                    }
                    else if (currency2 == "GBP")
                    {
                        temp = .0071;
                        value = value * temp;
                    }
                    else if (currency2 == "CNY")
                    {
                        temp = .065;
                        value = value * temp;
                    }
                    break;
                case "CAN": //converting from CAN to another currency
                    if (currency2 == "USD")
                    {
                        temp = .76;
                        value = value * temp;
                    }
                    else if (currency2 == "EUR")
                    {
                        temp = .69;
                        value = value * temp;
                    }
                    else if (currency2 == "YEN")
                    {
                        temp = 83.02;
                        value = value * temp;
                    }
                    else if (currency2 == "CAN")
                    {
                        temp = 1;
                        value = value * temp;
                    }
                    else if (currency2 == "GBP")
                    {
                        temp = .59;
                        value = value * temp;
                    }
                    else if (currency2 == "CNY")
                    {
                        temp = 5.40;
                        value = value * temp;
                    }
                    break;
                case "GBP": //converting from GBP to another currency
                    if (currency2 == "USD")
                    {
                        temp = 1.29;
                        value = value * temp;
                    }
                    else if (currency2 == "EUR")
                    {
                        temp = 1.16;
                        value = value * temp;
                    }
                    else if (currency2 == "YEN")
                    {
                        temp = 140.27;
                        value = value * temp;
                    }
                    else if (currency2 == "CAN")
                    {
                        temp = 1.69;
                        value = value * temp;
                    }
                    else if (currency2 == "GBP")
                    {
                        temp = 1;
                        value = value * temp;
                    }
                    else if (currency2 == "CNY")
                    {
                        temp = 9.13;
                        value = value * temp;
                    }
                    break;
                case "CNY": //converting from CNY to another currency
                    if (currency2 == "USD")
                    {
                        temp = .14;
                        value = value * temp;
                    }
                    else if (currency2 == "EUR")
                    {
                        temp = .13;
                        value = value * temp;
                    }
                    else if (currency2 == "YEN")
                    {
                        temp = 15.36;
                        value = value * temp;
                    }
                    else if (currency2 == "CAN")
                    {
                        temp = .19;
                        value = value * temp;
                    }
                    else if (currency2 == "GBP")
                    {
                        temp = .11;
                        value = value * temp;
                    }
                    else if (currency2 == "CNY")
                    {
                        temp = 1;
                        value = value * temp;
                    }
                    break;
                default: 
                    value = 0.00;
                    break;
            } //return the new value
            return value;
        }
    }
}
