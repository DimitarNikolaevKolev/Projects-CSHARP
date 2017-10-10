using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeVendingMachineProblem1
{
    class Program
    {
        static void Main(string[] args)
        {
            float N1 = 0.05f;
            float N2 = 0.10f;
            float N3 = 0.20f;
            float N4 = 0.50f;
            float N5 = 1.00f;

            
            int numberN1 = int.Parse(Console.ReadLine());
            
            int numberN2 = int.Parse(Console.ReadLine());
            
            int numberN3 = int.Parse(Console.ReadLine());
            
            int numberN4 = int.Parse(Console.ReadLine());
            
            int numberN5 = int.Parse(Console.ReadLine());

            
            float amountA = float.Parse(Console.ReadLine());

            
            float drinkP = float.Parse(Console.ReadLine());

            float moneyInMachine = N1 * numberN1 + N2 * numberN2 + N3 * numberN3 + N4 * numberN4 + N5 * numberN5;
            float change = 0;

            
            if (amountA > drinkP)
            {
                change = amountA - drinkP;
                float sumYes = 0;

                if (moneyInMachine > change)
                {                 
                    sumYes = moneyInMachine-change;
                    Console.WriteLine("Yes {0:0.00}", sumYes);

                }
                else 
                {
                    Console.WriteLine("No {0:0.00}", amountA - drinkP - moneyInMachine);
                }
            }

            if (amountA < drinkP)
            {
                Console.WriteLine("More {0:0.00}", drinkP - amountA);
            }
        }
    }
}
