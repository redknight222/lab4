using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int positiveNumbers = 0, negativeNumbers = 0, numbers;
            do
            {
                numbers = Convert.ToInt32(Console.ReadLine());
                positiveNumbers += (numbers > 0) ? 1 : 0;
                negativeNumbers += (numbers < 0) ? 1 : 0;
            } while (numbers != 0);
            if (positiveNumbers > negativeNumbers)
            {
                Console.WriteLine("Positive numbers {0} > {1} Negative numbers", positiveNumbers, negativeNumbers);
                Console.ReadKey();
            }
            else if (positiveNumbers < negativeNumbers)
            {
                Console.WriteLine("Positive numbers {0} < {1} Negative numbers", positiveNumbers, negativeNumbers);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Positive numbers {0} = {1} Negative numbers", positiveNumbers, negativeNumbers);
                Console.ReadKey();
            }
        }
    }
}
