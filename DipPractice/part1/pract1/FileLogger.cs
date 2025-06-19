using DipPractice.pract1;
using System;
using System.IO;
using System.Linq;

namespace DipPractice
{
    internal class FileLogger : ILogger
    {
        public void Log(string result)
        {
            File.AppendAllText("log.txt", result + Environment.NewLine);
            Console.WriteLine("log write to file!!!");
        }
    }
}
