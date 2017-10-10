using System;

namespace DrunkMitkoandVlado
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int n = int.Parse(Console.ReadLine());
            int[] num = new int[n];

            for (int i = 0; i < n; i++)
            {
                num[n] = int.Parse(Console.ReadLine());
                n = n + 1;
  
            }
            






            Console.WriteLine("1) The length of '{0}' is {1}", n, num);
            Console.WriteLine("first string of number is: ", num);

            


        }
    }
}
