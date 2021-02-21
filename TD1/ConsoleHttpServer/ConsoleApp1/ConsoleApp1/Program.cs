using System;
using System.IO;

namespace ConsoleApp1
{
    class Program // Permet d'imiter un serveur HTTP depuis une console
    {
        static void Main(string[] args)
        {
            processRequest(args); 
        }

        private static void processRequest(string[] arguments)
        {
            string root = @"C:\Users\yannm\Documents\SI4\SOC\eiin839\TD1\ConsoleHttpServer\ConsoleApp1\ConsoleApp1\FilesToExpose\"; // le chemin du dossier pour lequel on autorise d'accéder aux fichiers 
            if (!arguments[0].Equals("GET")) // On ne gère que les requêtes GET pour le moment
            {
                Console.WriteLine("http/1.0 500 Internal Server Error\n\n\n" + "<HTML><BODY> Only GET requests are supported </BODY></HTML>");
                return;
            }
            if (arguments.Length < 2) // Il n'y pas assez d'arguments qui sont spécifiés comme arguments de lignes de commande
            {
                Console.WriteLine("http/1.0 400 Bad request\n\n\n" + "<HTML><BODY> Can't access / </BODY></HTML>");
                return;
            }
            if (!File.Exists(root + arguments[1])) // le fichier demandé n'existe pas dans le dossier
            {
                Console.WriteLine("http/1.0 404 Not Found\n\n\n" + "<HTML><BODY> Ressource not found </BODY></HTML>");
                return;
            }
            string text = File.ReadAllText(root + arguments[1]);
            Console.WriteLine("http/1.0 200 OK\n\n\n" + text); // On renvoie le header 200 OK en plus du contenu du fichier demandé

        }
    }
}

