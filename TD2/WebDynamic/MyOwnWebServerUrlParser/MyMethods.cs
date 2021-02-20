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
        public string ReturnHtml(String query)
        {
            String param1 = HttpUtility.ParseQueryString(query).Get("param1");
            String param2 = HttpUtility.ParseQueryString(query).Get("param2");
            return "<HTML><BODY> Hello " + param1 + " et " + param2 + " </BODY></HTML>";
        }
    }
}
