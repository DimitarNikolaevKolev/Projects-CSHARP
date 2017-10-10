using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int lines = int.Parse(input);
            int elementsOnLines = lines;
            int center = elementsOnLines / 2;

            for (int i = 1; i <= center; i++) // i e reda na koito se namirame!
            {
                int elPos = 1;
                while (elPos <= elementsOnLines )
                {
                    if ((elPos <= center - i) || (elPos > center + i))
                    {
                        Console.Write(".");

                        elPos++;

                    }
                    else
                    {
                        for (int j = 0; j < i; j++)
                        {
                            if (j%2 == 0)
                            {
                                Console.Write("/");
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                            elPos++;
                        }
                        for (int j = i; j > 0; j--)
                        {
                            if (j%2 == 0)
                            {
                                Console.Write(" ");
                            }
                            else
                            {
                                Console.Write("\\");
                            }
                            elPos++;
                        }
                        
                    }
                    

                }
               
                Console.WriteLine();
            }



            //Dolna poluvina na zadachata (ogledalna na gornata)
            for (int i = center; i >= 1; i--)
            {
                int elPos = 1;
                while (elPos <= elementsOnLines + 1)
                {
                    if ((elPos <= center - i) || (elPos > center + i))
                    {
                        Console.Write(".");
                    }
                    else
                    {
                        for (int j = 0; j < i; j++)
                        {
                            if (j % 2 == 0)
                            {
                                Console.Write("\\");
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                            elPos++;
                        }
                        for (int j = i; j > 0; j--)
                        {
                            if (j % 2 != 0)
                            {
                                Console.Write("/");
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                            elPos++;
                        }
                    }
                    elPos++;

                }
                Console.WriteLine();
            }



        }
    }
}
