using System;
using System.Diagnostics;

namespace CallPythonScript
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"C:\Users\yannm\Documents\SI4\SOC\eiin839\TD2\CallPythonScript\externalScript.py";

            Process p = new Process();
            p.StartInfo = new ProcessStartInfo(@"C:\\Users\\yannm\\AppData\\Local\\Programs\\Python\\Python37\\python.exe", fileName)
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            p.Start();

            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();

            Console.WriteLine(output);

            Console.ReadLine();
        }
    }
}
