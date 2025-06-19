using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DipPractice.pract3
{
    internal class DroneDispatchAlert : IAlert
    {
        public void Alert()
        {
            Console.WriteLine(" Drones dispatched to threat location! base in danger");
        }
    }
}
