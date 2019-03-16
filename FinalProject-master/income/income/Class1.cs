using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalGrpXML
{
    [Serializable]
    public class Class1
    {
        private int code;
        private string status;
        private string copyright;
        private string attributionText;
        private string attributionHTML;
        private string etag;
        private Data data;

        public int Code { get => code; set => code = value; }
        public string Status { get => status; set => status = value; }
        public string Copyright { get => copyright; set => copyright = value; }
        public string AttributionText { get => attributionText; set => attributionText = value; }
        public string Etag { get => etag; set => etag = value; }
        public Data Data { get => data; set => data = value; }
        public string AttributionHTML { get => attributionHTML; set => attributionHTML = value; }
    }
}