using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace income
{
    public partial class AutoComplete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Clear();

            string term = Request.QueryString["term"];
            if(!term.Equals(null))
                if (term.Length > 0)
            Response.Write(new LocationToJson().getCountiesJson(term));

            Response.End();

        }
    }
}