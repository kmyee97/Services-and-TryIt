using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MoneyConversion
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        //easy service
        [OperationContract]
        [WebGet(UriTemplate = "moneyConvert?value={value}&currency1={currency1}&currency2={currency2}")] //creating a RESTful service
        double moneyConvert(double value, string currency1, string currency2);

    }
}
