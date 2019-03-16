using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace income
{
    public class Location
    {
        private string id;
        private string state;
        private string county;

        public Location() {

        }

        public Location(string id, string state, string county) {
            this.id = id;
            this.state = state;
            this.county = county;
        }
        public string Id { get => id; set => id = value; }
        public string State { get => state; set => state = value; }
        public string County { get => county; set => county = value; }
    }
}