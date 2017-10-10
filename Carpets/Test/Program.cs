using System;

namespace CarpetsArray
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int rowsUp = N / 2;
            int sideDots = (N / 2) - 1;
            int middle = N / 2;

            for (int i = 1; i <= rowsUp; i++)          // Горна част
            {
                Console.Write(new string('.', sideDots));   // Лява част
                for (int j = 1; j <= i; j++)
                {
                    if (j % 2 != 0)
                    {
                        Console.Write("/");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                
                for (int f = 1; f <= i; f++)                // Дясна част
                {
                    if (i % 2 != 0)
                    {
                        if (f % 2 != 0)
                        {
                            Console.Write("\\");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    else
                    {
                        if (f % 2 != 0)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write("\\");
                        }
                    }
                }
                Console.Write(new string('.', sideDots));
              
                sideDots--;
                Console.WriteLine();
            }






            sideDots = 0;
            for (int i = rowsUp; i > 0; i--)          // Долна част
            {
                Console.Write(new string('.', sideDots));   // Лява част
                for (int j = 1; j <= i; j++)
                {
                    if (j % 2 != 0)
                    {
                        Console.Write("\\");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }


                for (int f = 1; f <= i; f++)                // Дясна част
                {
                    if (i % 2 != 0)
                    {
                        if (f % 2 != 0)
                        {
                            Console.Write("/");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    else
                    {
                        if (f % 2 != 0)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write("/");
                        }
                    }
                }
                Console.Write(new string('.', sideDots));

                sideDots++;
                Console.WriteLine();
            }

        }
    }
}