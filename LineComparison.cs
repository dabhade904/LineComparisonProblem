using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    /// <summary>
    /// Line Comparison Problem
    /// </summary>
    public class LineComparison
    {
        public static float cordinatesOfLineOne()
        {
            Console.WriteLine("Please provide endpoint for line 1");
            float distance;
            Console.WriteLine("Enter point x1,x2");
            float x1=float.Parse(Console.ReadLine());
            float x2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter point y1,y2");
            float y1 = float.Parse(Console.ReadLine());
            float y2 = float.Parse(Console.ReadLine());

            distance = (float)Math.Sqrt(((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)));
            return distance;
        }
        public static float cordinatesOfLineTwo()
        {
            Console.WriteLine("Please provide endpoint for line 2");
            float distance;
            Console.WriteLine("Enter point x1,x2");
            float x1 = float.Parse(Console.ReadLine());
            float x2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter point y1,y2");
            float y1 = float.Parse(Console.ReadLine());
            float y2 = float.Parse(Console.ReadLine());
            distance = (float)Math.Sqrt(((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)));
            return distance;
        }
    }
}
