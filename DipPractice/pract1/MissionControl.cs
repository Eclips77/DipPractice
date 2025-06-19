using System;
namespace DipPractice.pract1
{
    internal class MissionControl
    {
        private ILogger Logger;
        public MissionControl(ILogger logger)
        {
            this.Logger = logger;
        }

        public void mission()
        {
            Console.WriteLine("enter the mission txt");
            string missionTxt = Console.ReadLine();
            Logger.Log(missionTxt);
        }
    }
}
