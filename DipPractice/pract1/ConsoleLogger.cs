using DipPractice.pract1;
using System;

namespace DipPractice
{
    internal class ConsoleLogger : ILogger
    {
        public void Log(string result)
        {
            Console.WriteLine($"the mission resul is {result}");
        }
    }
}
