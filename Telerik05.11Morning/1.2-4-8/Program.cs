using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2_4_8
{
    class Program
    {
        static void Main(string[] args)
        {
            uint numberA = uint.Parse(Console.ReadLine());
            uint numberB = uint.Parse(Console.ReadLine());
            uint numberC = uint.Parse(Console.ReadLine());

            uint numberR = 0;

            if (numberB == 2)
            {
                numberR = numberA % numberC;
                if (numberR % 4 == 0)
                {
                    Console.WriteLine(numberR / 4);
                }
                else
                {
                    Console.WriteLine(numberR % 4);
                }

                Console.WriteLine(numberR);
            }
            if (numberB == 4)
            {
                numberR = numberA + numberC;
                if (numberR % 4 == 0)
                {
                    Console.WriteLine(numberR / 4);
                }
                else
                {
                    Console.WriteLine(numberR % 4);
                }

                Console.WriteLine(numberR);
            }
            if (numberB == 8)
            {
                numberR = numberA * numberC;
                if (numberR % 4 == 0)
                {
                    Console.WriteLine(numberR / 4);
                }
                else
                {
                    Console.WriteLine(numberR % 4);
                }

                Console.WriteLine(numberR);
            }
        }
    }
}
