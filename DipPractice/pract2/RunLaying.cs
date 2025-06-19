using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DipPractice.pract2
{
    public static class RunLaying
    {
        public static void Run()
        {
            ILieDetector detector1 = new VoiceAnalyzer();
            ILieDetector detector2 = new ThermalScanner();

            var unit1 = new TerroristInterrogationUnit(detector1);
            var unit2 = new TerroristInterrogationUnit(detector2);

            unit1.Interrogate("voice pattern normal");
            unit1.Interrogate("voice shows tremble");

            unit2.Interrogate("no heat");
            unit2.Interrogate("heat spike detected");
        }
    }
}
