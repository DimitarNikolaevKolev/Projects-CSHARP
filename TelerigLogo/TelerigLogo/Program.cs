using System;


namespace TelerigLogo
{
    class Program
    {
        static void Main()
        {
            int X = int.Parse(Console.ReadLine());

            int width = (X + X) + ((X / 2) + 1) + ((X / 2) + 1) - 3;
            int hornslength = X / 2;                 // izchilqvane na rogata
            int middleDots = width - 2 * ((X / 2) + 1);


            Console.Write(new string('.', hornslength));    //parvi red
            Console.Write("*");                                 //parvi red
            Console.Write(new string('.', middleDots));        //parvi red
            Console.Write("*");                             //parvi red
            Console.Write(new string('.', hornslength));        //parvi red
            Console.WriteLine();

            middleDots -= 2;

            int firsthHornDots = (X / 2) - 1;
            int dotsAfterHorn = 0;

            for (int i = 1; i < X - 1; i++)   //cikal za fir mejdu parvi red i sreden red
            {
                //add real horns
                if (i <= X /2)
                {
                    Console.Write(new string('.', firsthHornDots));
                    Console.Write("*");
                    Console.Write(new string('.', dotsAfterHorn));
                    
                }
                else
                {
                    Console.Write(new string('.', hornslength));
                }


                Console.Write(new string('.', i));    //mejdu rogata na logoto
                Console.Write("*");                   //mejdu rogata na logoto
                Console.Write(new string('.', middleDots)); //mejdu rogata na logoto
                Console.Write("*");                         //mejdu rogata na logoto
                Console.Write(new string('.', i));      //mejdu rogata na logoto

                middleDots -= 2;

                //add real horns
                if (i <= X / 2)
                {
                    Console.Write(new string('.', dotsAfterHorn));
                    Console.Write("*");
                    Console.Write(new string('.', firsthHornDots));

                    firsthHornDots--;
                    dotsAfterHorn++;
                }
                else
                {
                    Console.Write(new string('.', hornslength));
                }

                Console.WriteLine();
            }

            Console.Write(new string('.', width / 2));     // pechatane na sredata, kadeto se presichat liniete s edna *
            Console.Write("*");                          // pechatane na sredata, kadeto se presichat liniete s edna *
            Console.Write(new string('.', width / 2));       // pechatane na sredata, kadeto se presichat liniete s edna *
            Console.WriteLine();


            int downmiddledots = 1;
            for (int i = X - 2; i >= 0; i--)            // dolni redove
            {


                Console.Write(new string('.', hornslength));

                Console.Write(new string('.', i));
                Console.Write("*");
                Console.Write(new string('.', downmiddledots));
                Console.Write("*");
                Console.Write(new string('.', i));
                downmiddledots += 2;

                Console.Write(new string('.', hornslength));

                Console.WriteLine();
            }



            int bottomMiddleDots = (width - 2 * ((X / 2) + 1)) - 2;
            for (int i = 1; i < X - 1; i++)   // otnovo cikal ot po gore
            {

                Console.Write(new string('.', hornslength));


                Console.Write(new string('.', i));
                Console.Write("*");
                Console.Write(new string('.', bottomMiddleDots));
                Console.Write("*");
                Console.Write(new string('.', i));

                bottomMiddleDots -= 2;


                Console.Write(new string('.', hornslength));
                Console.WriteLine();
            }


            Console.Write(new string('.', width / 2));     // Posleden red e raven na sreden red s edna *
            Console.Write("*");
            Console.Write(new string('.', width / 2));
            Console.WriteLine();

        }
    }
}
