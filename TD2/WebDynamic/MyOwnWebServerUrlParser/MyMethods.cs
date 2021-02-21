using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Web;

namespace MyOwnWebServerUrlParser
{
    class MyMethods
    {
        public string ReturnHtml(String query) //Vient parser l'URL pour récupérer les valeurs param1 et param2 d'une URL de la forme http://localhost:8080/quelquechose?param1=John&param2=Hector
        {
            String param1 = HttpUtility.ParseQueryString(query).Get("param1");
            String param2 = HttpUtility.ParseQueryString(query).Get("param2");
            return "<HTML><BODY> Hello " + param1 + " et " + param2 + " </BODY></HTML>";
        }
    }
}
