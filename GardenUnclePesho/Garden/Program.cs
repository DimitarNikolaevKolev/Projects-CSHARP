using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            float tomatoPrice = 0.5f;
            float cucumberPrice = 0.4f;
            float potatoPrice = 0.25f;
            float carrotPrice = 0.6f;
            float cabbagePrice = 0.3f;
            float beansPrice = 0.4f;

            byte Area = 250;

            int tomatoSeedsAmount = int.Parse(Console.ReadLine());
            byte tomatoArea = byte.Parse(Console.ReadLine());

            int cucumberSeedsAmount = int.Parse(Console.ReadLine());
            byte cucumberArea = byte.Parse(Console.ReadLine());

            int potatoSeedsAmount = int.Parse(Console.ReadLine());
            byte potatoArea = byte.Parse(Console.ReadLine());

            int carrotSeedsAmount = int.Parse(Console.ReadLine());
            byte carrotArea = byte.Parse(Console.ReadLine());

            int cabbageSeedsAmount = int.Parse(Console.ReadLine());
            byte cabbageArea = byte.Parse(Console.ReadLine());

            int beansSeedsAmount = int.Parse(Console.ReadLine());
            int beansArea = 0;

            float Total = tomatoPrice * tomatoSeedsAmount + cucumberPrice * cucumberSeedsAmount + potatoPrice * potatoSeedsAmount + carrotPrice * carrotSeedsAmount + cabbagePrice * cabbageSeedsAmount + beansPrice * beansSeedsAmount;
            Console.WriteLine("Total costs: {0:0.00}", Total);


            int sumArea = tomatoArea + cucumberArea + potatoArea + carrotArea + cabbageArea;
            
            if (sumArea > Area)
            {
                Console.WriteLine("Insufficient area");
            }
            else
            {
                beansArea = Area - sumArea;
            }

            if (sumArea == Area)
            {
                Console.WriteLine("No area for beans");
            }
            if (beansArea > 0)
            {
            Console.WriteLine("Beans area: {0}",beansArea);
            }
        }
    }
}
