using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace income
{
    public class LocationToJson
    {


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string regionList()
        {
            List<Location> lcnLst = new List<Location>();
            using (StreamReader sr = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "location.csv"))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    lcnLst.Add(new Location(line.Split(',').ToList()[0], line.Split(',').ToList()[1], line.Split(',').ToList()[2]));
                }

            }
            string str = JsonConvert.SerializeObject(lcnLst);

            return str;

        }

        public string getRegionID(string regionName)
        {
            List<Location> lcnLst = new List<Location>();
            using (StreamReader sr = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "location.csv"))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Split(',').ToList()[2].ToLower().Contains(regionName.ToLower()))
                        return line.Split(',').ToList()[0];
                }

            }
            return "unable to find region";
        }

        public string getCountiesJson(string countyName) {
            List<string> cntList = new List<string>();
            using (StreamReader sr = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "location.csv"))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Split(',').ToList()[2].ToLower().Contains(countyName.ToLower()))
                        cntList.Add(line.Split(',').ToList()[2]);
                }

            }
            return JsonConvert.SerializeObject(cntList);
        }


    }
}