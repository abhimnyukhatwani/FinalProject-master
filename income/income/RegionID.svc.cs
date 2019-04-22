using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;
using System.IO;

namespace income
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RegionID" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select RegionID.svc or RegionID.svc.cs at the Solution Explorer and start debugging.
    public class RegionID : IRegionID
    {
        public string getRegionID(string regionName)
        {
            return new LocationToJson().getRegionID(regionName);
        }

        public Stream getRegionList()
        {
            string str = new LocationToJson().regionList();


            WebOperationContext.Current.OutgoingResponse.ContentType = "application/json; charset=utf-8";
            return new MemoryStream(Encoding.UTF8.GetBytes(str));
            
        }
    }
}
