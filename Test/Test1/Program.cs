using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {

            //int A = int.Parse(Console.ReadLine());
            //Console.WriteLine(Convert.ToString(A, 2).PadLeft(32, '0'));
            //int B = int.Parse(Console.ReadLine());
            //Console.WriteLine(Convert.ToString(B, 2).PadLeft(32, '0'));
            //int C = int.Parse(Console.ReadLine());
            //Console.WriteLine(Convert.ToString(C, 2).PadLeft(32, '0'));
            //Console.WriteLine();
            //Console.WriteLine("Result: ");
            //int temp = A ^ B;
            //int D = temp ^ C;
            //Console.WriteLine(temp ^ C);
            //Console.WriteLine(Convert.ToString(D, 2).PadLeft(32, '0'));
            int a = 0;
            int b = -1;
            for (int i = 0; i < 500; i++)
            {
                Console.WriteLine(a+=2);
                Console.WriteLine(b-=2);
            }
        }
    }
}
