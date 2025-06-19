using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DipPractice.part2.exercise2
{
    public static  class Exercise2Run
    {
        public static void TestArea(IShape shape)
        {
            Console.WriteLine($"Area: {shape.Area()}");
        }

    }
}
