using System;
using System.Collections.Generic;

namespace geometry
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Quadrat q = new Quadrat(5, 7);
            List<Geometry> quadratList = new List<Geometry>();
            foreach (Quadrat quadrat in quadratList)
            {
                Console.WriteLine(q.ToString());
            }


            Console.ReadKey();

        }
    }
}
