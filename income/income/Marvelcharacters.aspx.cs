using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using unirest_net.http;
using System.Web.Script.Serialization;
using System.Net;
using System.Collections.Generic;

namespace FinalGrpXML
{
    public partial class Marvelcharacters : System.Web.UI.Page
    {
        List<Movie> Movies = new List<Movie>();
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //var Name = Search.ToString().ToLower();
            HttpResponse<string> jsonResponse = Unirest.get("http://gateway.marvel.com/v1/public/comics?ts=4&apikey=3383466d8b0414e4023b15b98679a595&hash=5bdb1734825323141518a12cd47807b7").asString();
            string responseBody = jsonResponse.Body;
            Class1 MarvelCharacters = JsonConvert.DeserializeObject<Class1>(responseBody);
            for (int i = 0; i < 15; i++)
            {
                Movies.Add(new Movie(MarvelCharacters.Data.Results[i].Title, MarvelCharacters.Data.Results[i].VariantDescription, MarvelCharacters.Data.Results[i].Description, MarvelCharacters.Data.Results[i].Description, MarvelCharacters.Data.Results[i].Description, MarvelCharacters.Data.Results[i].Format));
            }
        }
        public string DisplayResults()
        {
            //We have taken this piece of code referrence from the TeamRed but we will change and improvise it in the nexit commit--Begins
            string htmlStr = "";
            htmlStr += "<div class='container'> <div class='row'>";
            htmlStr += "<table class='table table-bordered table-striped'>";
            if(IsPostBack)
            htmlStr += "<tr><th>Movies</th><th>Genre</th></tr>";
            foreach (var movie in Movies)
            {
            
                htmlStr +=
                    "<tr><td> <div class='title'>" + movie.Title1 +
                    "</div></td><td><div class='rating'>Genre- "
                    + movie.Format + "</div></td></tr>";

            }
            htmlStr += "</table></div> </div>";
            return htmlStr;
            ////We have taken this piece of code referrence from the TeamRed but we will change and improvise it in the nexit commit--Ends
        }





    }
}