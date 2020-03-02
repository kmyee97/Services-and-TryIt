using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Script.Serialization;

namespace Assignment6
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public class TheRoot    //A class to define and parse the first service 
        {
            [JsonProperty("Error Message")]
            public string Error { get; set; }
            [JsonProperty("Global Quote")]
            public GlobalQuote Global_Quote { get; set; }
            public class GlobalQuote
            {
                [JsonProperty("01. symbol")]
                public string Symbol { get; set; }

                [JsonProperty("02. open")]
                public string Open { get; set; }

                [JsonProperty("03. high")]
                public string High { get; set; }

                [JsonProperty("04. low")]
                public string Low { get; set; }

                [JsonProperty("05. price")]
                public string Price { get; set; }

                [JsonProperty("06. volume")]
                public string Volume { get; set; }

                [JsonProperty("07. latest trading day")]
                public string Latesttradingday { get; set; }

                [JsonProperty("08. previous close")]
                public string Previousclose { get; set; }

                [JsonProperty("09. change")]
                public string Change { get; set; }

                [JsonProperty("10. change percent")]
                public string Changepercent { get; set; }
            }
        }
        public class OtherRoot  //A class to define and parse the second service 
        {
            public List<art> articles { get; set; }
            public class art
            {
                public string url { get; set; }
            }
        }
        //Have one service that uses two services
        public string Stockquote(string symbol) // First service = to get the price of the current stock symbol
        {
            string theJsonOutput = "";
            string message = "";
            //convert the symbol string to uppercase cause the api only accepts if all chars' in the string are uppercase
            symbol = symbol.ToUpper();
            //get the url of the api and create a WebRequest object
            string theURL = String.Format("https://www.alphavantage.co/query?function=GLOBAL_QUOTE&symbol="+symbol+ "&apikey=98VHMBGDEI4X11XX");
            WebRequest theRequest = null;
            theRequest = WebRequest.Create(theURL);
            //make the method a get
            theRequest.Method = "GET";
            //create HttpWebResponse object and have it equal to the (HttpWebResponse) response()
            HttpWebResponse Stockresponse = null;
            Stockresponse = (HttpWebResponse)theRequest.GetResponse();
            //create Stream obj from HttpWebResponse obj
            Stream StockresponseStream = null;
            StockresponseStream = Stockresponse.GetResponseStream();
            //get the output of the api and put into a string variable
            var theReadingObject = new StreamReader(StockresponseStream);
            theJsonOutput = theReadingObject.ReadToEnd();
            //use the JsonConvert and deserialize to parse the json and get the information
            var stocksInfo = JsonConvert.DeserializeObject<TheRoot>(theJsonOutput);
            if (stocksInfo.Error == "Invalid API call. Please retry or visit the documentation (https://www.alphavantage.co/documentation/) for GLOBAL_QUOTE.")
            {//if empty send a message to type another ticket symbol
                message = "Stock is not showing up. Please enter a new stock symbol.";
                return message;
            }
            else
            {
                //getting all the information so i can return a string
                string gettingPrice = stocksInfo.Global_Quote.Price;
                string gettingDay = stocksInfo.Global_Quote.Latesttradingday;
                string gettingOpen = stocksInfo.Global_Quote.Open;
                string gettingLowest = stocksInfo.Global_Quote.Low;
                string gettingHighest = stocksInfo.Global_Quote.High;
                string gettingchange1 = stocksInfo.Global_Quote.Change;
                string gettingchange2 = stocksInfo.Global_Quote.Changepercent;
                message = "The latest trading day is: " + gettingDay + "\n" + symbol + " opened with $" + gettingOpen + "\n" + symbol + " highest price is $" + gettingHighest + " and lowest price is $" + gettingLowest
                    + "\n" + "Total change of the current stock is " + gettingchange1 + " (Percentage-wise is " + gettingchange2 + ")" + "\n" + symbol + " current price is $" + gettingPrice;
                return message;
            }
        }
        public string Stocknews(string symbol)  //Second Service = to get the 3 urls that are newsworthy of the current stock symbol
        {
            //string vars that holds important info
            string newsOutput = "";
            string urlOutput = "";
            //convert the symbol string to uppercase cause the api only accepts if all chars' in the string are uppercase
            symbol = symbol.ToUpper();
            //get the url of the api and create a WebRequest object
            //create a string called apikey that holds the api key and some part of the search keywords
            string apikey = "+stock+news&apiKey=5fe9f8d26784456583ec3dc2d2e70446";
            string theURL = String.Format("https://newsapi.org/v2/everything?q=" + symbol + apikey);
            //create the webrequest object
            WebRequest theRequest = null;
            theRequest = WebRequest.Create(theURL);
            //make the method a get since this service is getting info
            theRequest.Method = "GET";
            //create HttpWebResponse object and have it equal to the (HttpWebResponse) response()
            HttpWebResponse StockNewsResponse = null;
            StockNewsResponse = (HttpWebResponse)theRequest.GetResponse();
            //create Stream obj from the HttpWebResponse obj
            Stream StockresponseStream = null;
            //call the GetResponseStream
            StockresponseStream = StockNewsResponse.GetResponseStream();
            //get the output of the api and put into a string so it can be access
            var ReadingObj = new StreamReader(StockresponseStream);
            newsOutput = ReadingObj.ReadToEnd(); //ReadToEnd reads the output to the very end
            //Create the JavaScriptSerializer obj
            JavaScriptSerializer Serializing = new JavaScriptSerializer();
            //use the JavaScriptSerializer obj to deserialize the string
            var stocksInfo = Serializing.Deserialize<OtherRoot>(newsOutput);
            if (!stocksInfo.articles.Any())
            {// if stock symbol is invalid return this message saying its invalid
                return "Please enter a valid stock symbol";
            }
            else
            { //get the urls (3 urls) and return it
                string url1 = stocksInfo.articles[0].url;
                string url2 = stocksInfo.articles[1].url;
                string url3 = stocksInfo.articles[2].url;
                urlOutput = (url1 + "\n" + url2 + "\n" + url3);
                return urlOutput;
            }
        }

    }
}
