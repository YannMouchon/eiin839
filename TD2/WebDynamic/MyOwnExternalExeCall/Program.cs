﻿using System;
using System.Diagnostics;
using System.IO;

namespace MyOwnExternalExeCall
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            // Set up the process with the ProcessStartInfo class.
            // https://www.dotnetperls.com/process
            //
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = @"C:\Users\yannm\Documents\SI4\SOC\eiin839\TD2\WebDynamic\MyOwnExecTest\bin\Debug\netcoreapp3.1\MyOwnExecTest.exe"; // Specify exe name.
            start.Arguments = "géantVert Johhhhhhhny"; // Specify arguments.
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            //
            // Start the process.
            //
            using (Process process = Process.Start(start))
            {
                //
                // Read in all the text from the process with the StreamReader.
                //
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    Console.WriteLine(result);
                    Console.ReadLine();
                }
            }
        }
    }
}
