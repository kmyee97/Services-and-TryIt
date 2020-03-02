using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Assignment6
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    { //this service includes 2 services
        [OperationContract]
        string Stockquote(string symbol); //service 1, get the stock info which pertains to trade date, current price, highest price, lowest price, opener, close, change, and change in percent form
        [OperationContract]
        string Stocknews(string symbol); //service 2, get a list of news urls that relates to the stock. outputs 3 urls.

    }
}
