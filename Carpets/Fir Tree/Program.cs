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
            int inNumber = int.Parse(Console.ReadLine());
            
            
            int startCount = 3;
            int dotCount = inNumber - 3;
            string stvol = new string('.', inNumber-2) + "*" + new string('.', inNumber-2);
            
            
            
            Console.WriteLine(stvol);                       //Stroi parvi red, koito e ednakaf s posledniq
            
            for (int i = 1; i < inNumber - 1; i++)          // Stroi srednite redove, zapochvaiki ot vtori red s 3 zvezdichki
            {
                Console.Write(new string('.', dotCount));     // narejda na red-a string "......" raven na vavedenoto chislo - 3
                Console.Write(new string('*', startCount));    // narejda do parviqt string na reda "***" raven na 3 ili  red-a + 2
                Console.Write(new string('.', dotCount));       // narejda do dvata stringa, string  "......" raven na vavedenoto chislo - 3
                Console.WriteLine();
                dotCount--;
                startCount += 2;                
            }
           
            Console.WriteLine(stvol);                     // Posleden red


        }
    }
}
