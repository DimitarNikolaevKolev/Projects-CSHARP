using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int dotsUpOut = N / 2 - 1;
            int linesUp = N / 2;
            int lineDown = N / 2;
            int dotsDownOut = 0;
            int dotsUpIn = 0;
            int dotsmiddleOut = 0;
            int dotsmiddleIn = dotsUpOut;

            for (int i = 0; i < linesUp; i++)
            {
                Console.Write(new string('.', dotsUpOut));
                Console.Write('#');
                Console.Write(new string('.', dotsUpIn));
                Console.Write('#');
                Console.Write(new string('.', dotsUpOut));
                Console.WriteLine();

                dotsUpOut--;
                dotsUpIn += 2;
            }

            for (int i = 0; i < N / 4; i++)
            {
                Console.Write(new string('.', dotsmiddleOut));
                Console.Write('#');
                Console.Write(new string('.', dotsmiddleIn));
                Console.Write(new string('.', dotsmiddleIn));
                Console.Write('#');
                Console.Write(new string('.', dotsmiddleOut));
                Console.WriteLine();
                dotsmiddleOut++;
                dotsmiddleIn--;

            }
            Console.WriteLine(new string('-', N));

            for (int i = 0; i < linesUp; i++)
            {
                Console.Write(new string('.', dotsDownOut));
                Console.Write(new string('\\', lineDown));
                Console.Write(new string('/', lineDown));
                Console.Write(new string('.', dotsDownOut));
                Console.WriteLine();
                dotsDownOut++;
                lineDown--;
            }
        }
    }
}
