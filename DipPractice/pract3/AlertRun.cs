using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DipPractice.pract3
{
    public static class AlertRun
    {
        public static void Run()
        {
            IAlert siren = new SirenAlert();
            IAlert drone = new DroneDispatchAlert();

            BaseDefenseController controller1 = new BaseDefenseController(siren);
            BaseDefenseController controller2 = new BaseDefenseController(drone);

            controller1.OnThreatDetected();
            controller2.OnThreatDetected();
        }
    }
}
