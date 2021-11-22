using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int j = Convert.ToInt32(Console.ReadLine());
            int n = 0;
            for (int i = 1; i < j + 1; i++)
            {
                n += 2 * i - 1;
                Console.WriteLine(n);
            }
            Console.ReadKey();
        }
    }
}
