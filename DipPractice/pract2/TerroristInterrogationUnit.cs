using DipPractice.pract2;
using System;

public class TerroristInterrogationUnit
{
    private readonly ILieDetector _lieDetector;

    public TerroristInterrogationUnit(ILieDetector lieDetector)
    {
        _lieDetector = lieDetector;
    }

    public void Interrogate(string suspectData)
    {
        Console.WriteLine("Starting interrogation...");
        bool isLying = _lieDetector.IsLying(suspectData);

        if (isLying)
            Console.WriteLine("Suspect is lying!");
        else
            Console.WriteLine("Suspect tells the truth.");
    }
}
