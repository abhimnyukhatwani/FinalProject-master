using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace income
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRegionID" in both code and config file together.
    [ServiceContract]
    public interface IRegionID
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/region/{regionName}", 
            RequestFormat =WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, 
            BodyStyle = WebMessageBodyStyle.Bare)]
        string getRegionID(string regionName);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/region",
            RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare)]
        Stream getRegionList();
    }
}
