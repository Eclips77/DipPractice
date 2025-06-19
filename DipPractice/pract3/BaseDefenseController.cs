using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DipPractice.pract3
{
    internal class BaseDefenseController
    {
        private readonly IAlert _alertUnit;
        public BaseDefenseController(IAlert alertUnit)
        {
            this._alertUnit = alertUnit;
        }
        public void OnThreatDetected()
        {
            Console.WriteLine("Threat detected!");
            _alertUnit.Alert();
        }
    }
}
