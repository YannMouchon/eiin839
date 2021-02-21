using System;
using System.Net;


namespace MyOwnHttpListener
{
    class HeadersReader
    {
        public void GetHeader(HttpListenerRequest request)
        {
            //!!!!!!!!!!!!!!!!!
            // Exemple trouvé sur https://docs.microsoft.com/en-us/dotnet/api/system.net.httplistenerrequest.headers?view=net-5.0
            System.Collections.Specialized.NameValueCollection headers = request.Headers;
            // On affiche tous les headers qui existe pour une requete HTTP faite sur notre localhost:8080 ou localhost:8081
            foreach (string key in headers.AllKeys)
            {
                string[] values = headers.GetValues(key);
                if (values.Length > 0) // Vérifie que le header a bien une valeur pour afficher sa valeur. Sinon n'affiche pas le nom du header en question
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
