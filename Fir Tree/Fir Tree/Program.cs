using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fir_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int sideDots = N - 2;
            int treeDots = 1;

            for (int i = 1; i < N; i++)
            {
                Console.Write(new string('.', sideDots));
                Console.Write(new string('*', treeDots));
                Console.Write(new string('.', sideDots));
                Console.WriteLine();

                sideDots--;
                treeDots += 2;
            }

            Console.Write(new string('.', N - 2));
            Console.Write("*");
            Console.Write(new string('.', N - 2));
            Console.WriteLine();

        }
    }
}
