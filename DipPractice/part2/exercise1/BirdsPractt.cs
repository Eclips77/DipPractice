//using System;

//public interface ICanFly
//{
//    void Fly();
//}

//public class Bird
//{
//    public string Name { get; set; }

//    public Bird(string name)
//    {
//        Name = name;
//    }
//}

//public class Sparrow : Bird, ICanFly
//{
//    public Sparrow(string name) : base(name) { }

//    public void Fly()
//    {
//        Console.WriteLine($"{Name} is flying high!");
//    }
//}

//public class BirdsPractt : Bird
//{
//    public BirdsPractt(string name) : base(name) { }
//}

//public class Program
//{
//    public static void MakeBirdFly(ICanFly bird)
//    {
//        bird.Fly();
//    }

//    public static void Main()
//    {
//        Sparrow sparrow = new Sparrow("Tiny Sparrow");
//        BirdsPractt penguin = new BirdsPractt("Chubby Penguin");

//        MakeBirdFly(sparrow);
//    }
//}
