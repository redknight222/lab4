using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectangle_ABC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sideA = Convert.ToInt32(Console.ReadLine());
            int sideB = Convert.ToInt32(Console.ReadLine());
            int sideC = Convert.ToInt32(Console.ReadLine());
            int countA = 0;
            int countB = 0;
            while (sideA > 0)
            {
                sideA -= sideC;
                countA += (sideA >= 0) ? 1 : 0;
            }
            while (sideB > 0)
            {
                sideB -= sideC;
                countB += (sideB >= 0) ? 1 : 0;
            }
            if (countA > 0 && countB > 0)
            {
                Console.WriteLine("Square number {0}", countA * countB);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Input error or zero squares");
                Console.ReadKey();
            }
            
        }
    }
}
