using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MyOwnBasicServerHTTPlistener
{
    class Header
    {
        public void GetHeader(HttpListenerRequest request)
        {
            //!!!!!!!!!!!!!!!!!
            // example found on https://docs.microsoft.com/en-us/dotnet/api/system.net.httplistenerrequest.headers?view=net-5.0
            System.Collections.Specialized.NameValueCollection headers = request.Headers;
            // Get each header and display each value.
            foreach (string key in headers.AllKeys)
            {
                string[] values = headers.GetValues(key);
                if (values.Length > 0)
                {
                    Console.WriteLine("The values of the {0} header are: ", key);
                    foreach (string value in values)
                    {
                        Console.WriteLine("   {0}", value);
                    }
                }
            }
        }
    }
}
