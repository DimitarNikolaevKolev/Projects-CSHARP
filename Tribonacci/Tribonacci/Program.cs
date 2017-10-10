using System;
using System.Collections.Generic;
using System.Numerics;

namespace Tribonacci
{
    class Program
    {
        static void Main()
        {
            BigInteger number1 = BigInteger.Parse(Console.ReadLine());
            BigInteger number2 = BigInteger.Parse(Console.ReadLine());
            BigInteger number3 = BigInteger.Parse(Console.ReadLine());

            int numberN = int.Parse(Console.ReadLine());


            if (numberN > 3)
            {
                for (int i = 3; i < numberN; i++)
                {
                    BigInteger tempNum = number1 + number2 + number3;
                    number1 = number2;
                    number2 = number3;
                    number3 = tempNum;
                }
                Console.WriteLine(number3);
            }

            if (numberN == 1)
            {
                Console.WriteLine(number1);
            }

            if (numberN == 2)
            {
                Console.WriteLine(number2);
            }

            if (numberN == 3)
            {
                Console.WriteLine(number3);
            }



        }
    }
}
