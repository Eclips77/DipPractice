using DipPractice.pract1;
using DipPractice.pract2;
using DipPractice.pract3;
using MissionSystemDIP;

namespace DipPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StartLogger.Run();
            //RunLaying.Run();
            //AlertRun.Run();

            ControlRoom controlRoom = new ControlRoom();
            controlRoom.Launch();

        }
    }
    

}
