using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using Newtonsoft.Json;
using System.Dynamic;
using Newtonsoft.Json.Converters;

namespace income
{
    public class income
    {

        public Dictionary<string, int> getIncome(int year, string county)
        {
            if (!(county.Equals("")))
            {
                string id = new LocationToJson().getRegionID(county);
                using (var WebClient = new WebClient())
                {
                    dynamic obj = new ExpandoObject();
                    //INCOME
                    string rawjson = WebClient.DownloadString("https://api.datausa.io/api/?sort=desc&force=acs.yg_income_distribution&show=geo&sumlevel=all&year=all&geo=" + id);
                    var incdata = JsonConvert.DeserializeObject<ExpandoObject>(rawjson, new ExpandoObjectConverter());


                    var data = incdata.ToList()[0].Value;
                    var header = incdata.ToList()[1].Value;
                    Dictionary<string, int> icb = new Dictionary<string, int>();
                    foreach (var rowData in (List<Object>)data)
                    {
                        if (((List<Object>)rowData).Count() == ((List<Object>)header).Count())
                        {
                            for (int i = 0; i < ((List<Object>)rowData).Count() - 2; i++)
                            {
                                if (i > 1 & year == int.Parse((((List<object>)rowData)[0]).ToString()) & i % 2 == 0)
                                    icb.Add((((List<Object>)header)[i]).ToString().Replace("income_", " ").Replace("to", " - ").Replace("under", "Under ").Replace("over", " and above"), int.Parse((((List<object>)rowData)[i]).ToString()));

                            }
                        }
                    }
                    return icb;
                }
            }
            Dictionary<string, int> nullDict = new Dictionary<string, int>();
            nullDict.Add("county cannot be blank", 0);
            return nullDict;

        }
    }
}