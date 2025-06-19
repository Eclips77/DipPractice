using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DipPractice.pract2
{
    public class ThermalScanner : ILieDetector
    {
        public bool IsLying(string suspectData)
        {
            return suspectData.Contains("heat spike");
        }
    }

}
