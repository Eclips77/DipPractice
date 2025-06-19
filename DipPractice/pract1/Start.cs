using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DipPractice.pract1
{
    public static class StartLogger
    {
        public static void Run()
        {
            ILogger logger = new ConsoleLogger();
            MissionControl mc = new MissionControl(logger);
            mc.mission();
        }
    }
}
