using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web.UI;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;
using System.Web.Script.Serialization;
using Newtonsoft.Json.Linq;

namespace secondService
{
    //have to make a class to get the address from the api (outputs a json doc). 
    class info
    {
        public resp response { get; set; }

        public class resp
        {
            public List<ven> venues { get; set; }

            public class ven
            {
                public loc location { get; set; }

                public class loc
                {
                    public string address { get; set; }
                }
            }
        }
        
        public override string ToString()
        {
            return string.Format("address: {0}", response.venues[0].location.address);
        }
    }
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    { 
        string IService1.findNearestStore(string zipcode, string storeName)
        {
            string answer = "";
            string line = "";
            //get the url of the service
            string serviceUrl = String.Format("https://api.foursquare.com/v2/venues/search?client_id=20CNZ5OMAZEWN4AANPI2ES5YLSWKGJKSX4UE3OCBGHHCY5UJ&client_secret=UHLEPAKC4WRX3ZP23J1UDEVKGZD31GIGDZ4R0TAPUEFWBHZD&v=20191018&near=" + zipcode + "&query=" + storeName + "&radius=32186");
            //make a webrequest object of the url
            WebRequest request = WebRequest.Create(serviceUrl);
            //make the method a get
            request.Method = "GET";
            //make a httpwebresponse object
            HttpWebResponse response = null;
            //make said object = to request.getresponse()
            response = (HttpWebResponse)request.GetResponse();
            //get the stream of the response
            Stream responseStream = response.GetResponseStream();
            JavaScriptSerializer ser = new JavaScriptSerializer();
            //convert the output of the service to a string
            using (var readingIt = new StreamReader(responseStream))
            {
                string theInfo = readingIt.ReadToEnd();
                line = theInfo;
            }       
            //use the deserialize to parse the json and get the address
            var in1 = ser.Deserialize<info>(line);
            if (!in1.response.venues.Any() == true)
            {//if empty set the answer string to none within 20 miles
                answer = "no stores within 20 miles";
                return answer;
            }
            string temp1 = in1.ToString();
            //get the address and return it
            string temp2 = in1.response.venues[0].location.address;
            answer = "The nearest store is located at " + temp2;
            return answer;
        }
    }
}
