using System;

namespace Test
{
    class Program
    {
        static void Main()
        {
            int numberN = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < numberN; i++)
            {

                int N = int.Parse(Console.ReadLine());

                string stringNumber = Convert.ToString(N, 2);
                int lenght = stringNumber.Length;
                string reversString = string.Empty;


                for (int j = lenght - 1; j >= 0; j--)
                {
                    if (stringNumber[j] == '1')
                    {
                        reversString += '1';
                    }
                    else
                    {
                        reversString += '0';
                    }

                }

                int D = Convert.ToInt32(reversString, 2);
                Console.WriteLine(D);



            }
        }

    }
}
