using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalGrpXML
{
    [Serializable]
    public class Data
    {
        private int offset;
        private int limit;
        private int total;
        private int count;
        private CharactersOfMarvel[] results;

        public int Offset { get => offset; set => offset = value; }
        public int Limit { get => limit; set => limit = value; }
        public int Total { get => total; set => total = value; }
        public int Count { get => count; set => count = value; }
        public CharactersOfMarvel[] Results { get => results; set => results = value; }
    }
}