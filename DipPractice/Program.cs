using DipPractice.pract1;

namespace DipPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new FileLogger();
            MissionControl mc = new MissionControl(logger);
            mc.mission();
        }
    }
}
