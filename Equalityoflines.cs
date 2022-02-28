using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
     class Equalityoflines
    {
        public static void comparelines()
        {
            float lengthA;
            float lengthB;

            Console.WriteLine("Enter the corordinates of line Ax1");
            int Ax1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the corordinates of line Ax2");
            int Ax2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the corordinates of line Ay1");
            int Ay1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the corordinates of line Ay2");
            int Ay2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the corordinates of 2nd line Bx1");
            int Bx1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the corordinates of line Bx2");
            int Bx2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the corordinates of line By1");
            int By1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the corordinates of line By2");
            int By2 = Convert.ToInt32(Console.ReadLine());

            int x = (Ax2 - Ax1) * (Ax2 - Ax1);
            int y = (Ay2 - Ay1) * (Ay2 - Ay1);
            lengthA = x + y;
            Console.WriteLine(Math.Sqrt(lengthA)); // Length of line A

            int u = (Bx2 - Bx1) * (Bx2 - Bx1);
            int v = (By2 - By1) * (By2 - By1);
            lengthB = u + v;
            Console.WriteLine(Math.Sqrt(lengthB)); // length of line B

            if(lengthA==lengthB)
            {
                Console.WriteLine("lineA and lineB are of equal length");

            }
            else
            {
                Console.WriteLine("LineA and lineB are  of unequal length");
            }
        }
    }
}
