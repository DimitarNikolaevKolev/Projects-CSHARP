using System;

namespace UK_FLAG
{
    class Program
    {
        static void Main()
        {
            int numberN = int.Parse(Console.ReadLine());
            int uppRows = numberN / 2;
            int dotsSideUp = 0;
            int dotsIn = (numberN / 2) - 1;



            for (int i = 0; i < uppRows; i++) // Горна част на Великогритаския флаг
            {
                Console.Write(new string('.', dotsSideUp));
                Console.Write("\\");
                Console.Write(new string('.', dotsIn));
                Console.Write("|");
                Console.Write(new string('.', dotsIn));
                Console.Write("/");
                Console.Write(new string('.', dotsSideUp));

                dotsIn--;
                dotsSideUp++;
                Console.WriteLine();
            }

            

            Console.Write(new string('-', uppRows));    // Среда на Великогритаския флаг
            Console.Write("*");                          // Среда на Великогритаския флаг
            Console.Write(new string('-', uppRows));       // Среда на Великогритаския флаг
            Console.WriteLine();

            dotsSideUp = (numberN / 2) - 1;
            dotsIn = 0;
            for (int i = 0; i < uppRows; i++) //Долна част на Великогритаския флаг
            {
                Console.Write(new string('.', dotsSideUp));
                Console.Write("/");
                Console.Write(new string('.', dotsIn));
                Console.Write("|");
                Console.Write(new string('.', dotsIn));
                Console.Write("\\");
                Console.Write(new string('.', dotsSideUp));

                dotsSideUp--;
                dotsIn++;
                Console.WriteLine();
            }


            Console.WriteLine();
        }
    }
}
