using System;

namespace MissionSystemDIP
{
    //  interfaces 
    public interface ILogger
    {
        void Log(string message);
    }

    public interface IIntelligenceService
    {
        string GatherIntel(string location);
    }

    public interface IMapService
    {
        string LoadMap(string location);
    }

    //  implementations 
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[FILE] {message}");
        }
    }

    public class IntelligenceService : IIntelligenceService
    {
        public string GatherIntel(string location)
        {
            return $"Enemy activity in {location}: HIGH";
        }
    }

    public class MapService : IMapService
    {
        public string LoadMap(string location)
        {
            return $"Loaded terrain map for {location}";
        }
    }

    //  high modole 
    public class MissionPlanner
    {
        private readonly ILogger _logger;
        private readonly IIntelligenceService _intelService;
        private readonly IMapService _mapService;

        public MissionPlanner(ILogger logger, IIntelligenceService intelService, IMapService mapService)
        {
            _logger = logger;
            _intelService = intelService;
            _mapService = mapService;
        }

        public void PlanMission(string location)
        {
            Console.WriteLine("=== Mission Plan ===");
            var intel = _intelService.GatherIntel(location);
            var map = _mapService.LoadMap(location);
            Console.WriteLine(intel);
            Console.WriteLine(map);
            _logger.Log($"Mission planned for {location}");
        }
    }

    //  entry point  
    public class ControlRoom
    {
        public void Launch()
        {
            ILogger logger = new FileLogger();
            IIntelligenceService intel = new IntelligenceService();
            IMapService map = new MapService();

            MissionPlanner planner = new MissionPlanner(logger, intel, map);
            planner.PlanMission("Sector 9");
        }
    }

  
}
