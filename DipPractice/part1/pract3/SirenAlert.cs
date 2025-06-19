using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DipPractice.pract3
{
    internal class SirenAlert : IAlert
    {
        public void Alert()
        {
            Console.WriteLine("Siren is blaring! all units alert in the base");
        }
    }
}
