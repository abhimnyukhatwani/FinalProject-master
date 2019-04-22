using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalGrpXML
{
    public class Movie
    {
        private string Title;
        private string variantDescription;
        private string description;
        private string url;
        private string prices;
        private string format;

        public Movie(string Title, string variantDescription, string description, string url, string prices, string format)
        {
            this.Title = Title;
            this.variantDescription = variantDescription;
            this.description = description;
            this.url = url;
            this.prices = prices;
            this.format = format;
        }

        public string Title1 { get => Title; set => Title = value; }
        public string VariantDescription { get => variantDescription; set => variantDescription = value; }
        public string Description { get => description; set => description = value; }
        public string Url { get => url; set => url = value; }
        public string Prices { get => prices; set => prices = value; }
        public string Format { get => format; set => format = value; }
    }
}