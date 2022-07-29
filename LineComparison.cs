using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    public class LineComparison
    {
        public void lineComLineComparisonProblem()
        {
            float distance;
            Console.WriteLine("enter point x1,y1");
            float x1=float.Parse(Console.ReadLine());
            float y1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter point x2,y2");
            float x2 = float.Parse(Console.ReadLine());
            float y2 = float.Parse(Console.ReadLine());
            float res = ((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            distance = (float)Math.Sqrt(res);

            Console.WriteLine("distance is : "+distance);


        }
    }
}
