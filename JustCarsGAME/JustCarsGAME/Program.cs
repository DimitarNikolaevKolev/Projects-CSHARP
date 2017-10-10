using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace JustCarsGAME
{
    struct Object             // Strukturi
    {
        public int x;   // publichni za da sa vidimi 
        public int y;
        public char c;
        public ConsoleColor color;     // izbroim tip s predvaritelno definirani 16 stoinosti - cvetove
    }

    class Program
    {
        static void PrintOnPosition(int x, int y, char c, ConsoleColor color = ConsoleColor.Gray)
        {
            Console.SetCursorPosition(x, y);   // Metod za premestvane na kursora za posiciq, zadadena chrez promenlivite "x" i "y"
            Console.ForegroundColor = color;   // Cvqt s koito kursora pishe
            Console.Write(c);                   // simvola koito iskame da otpechatame na poziciqta 

        }

        static void PrintStringOnPosition(int x, int y, string c, ConsoleColor color = ConsoleColor.Gray)
        {
            Console.SetCursorPosition(x, y);   // Metod za premestvane na kursora za posiciq, zadadena chrez promenlivite "x" i "y"
            Console.ForegroundColor = color;   // Cvqt s koito kursora pishe
            Console.Write(c);                   // simvola koito iskame da otpechatame na poziciqta 

        }


        static void Main()
        {
            int bonusBullet = 5;
            double speed = 100.0;   // Scorost
            double acceleration = 1;
            int playfielWidth = 5;  // razmer na poleto
            int livesCount = 5;    // jivoti na igra
            Console.BufferHeight = Console.WindowHeight = 20; // Premahvame ScrollBara kato fitvame bufera za vidimiq prozorec
            Console.BufferWidth = Console.WindowWidth = 30;  //

            Object userCar = new Object();            // Pravim si nashata kola
            userCar.x = 2;                         // izbirame poziciq na kolata
            userCar.y = Console.WindowHeight - 1; // izbirame poziciq na kolata
            userCar.c = '@';                     // kak izglejda kolata
            userCar.color = ConsoleColor.Yellow;// cvqt na kolata
           
            List<Object> Bullet = new List<Object>();
            Object Bullets = new Object();  // Patron

            Random randomGenerator = new Random();  // Generirame proizvolni chisla

            List<Object> objects = new List<Object>();   // Spisak ot kolichki, izpolzvame strukturata za koli

            while (true)
            {

                speed += acceleration;
                if (speed > 400)
                {
                    speed = 400;
                }

                bool hitted = false;
                {
                    int chance = randomGenerator.Next(0, 100); // dai mi random chislo mejdu 0 i 99
                    if (chance <= 10)
                    {
                        Object newObject = new Object();
                        newObject.color = ConsoleColor.DarkMagenta;
                        newObject.c = '^';
                        newObject.x = randomGenerator.Next(0, playfielWidth); // davame za "x" ramdom chilo mejdu 0 i kraq na poleto - 1
                        newObject.y = 0;
                        objects.Add(newObject);
                    }
                    else if (chance <= 20)                            // taka pravim v 20% ot slucheite zaedno s gorniqt red
                    {
                        // Dobavi bonus
                        Object newObject = new Object();
                        newObject.color = ConsoleColor.Cyan;
                        newObject.c = '*';
                        newObject.x = randomGenerator.Next(0, playfielWidth); // davame za "x" ramdom chilo mejdu 0 i kraq na poleto - 1
                        newObject.y = 0;
                        objects.Add(newObject);       // dobavqme bonusite na poleto (dobavqme gi v listata

                    }
                    else if (chance <= 30)
                    {
                        Object newObject = new Object();
                        newObject.color = ConsoleColor.White;
                        newObject.c = '?';
                        newObject.x = randomGenerator.Next(0, playfielWidth); // davame za "x" ramdom chilo mejdu 0 i kraq na poleto - 1
                        newObject.y = 0;
                        objects.Add(newObject); 

                    }else
                    {
                        Object newCar = new Object();
                        newCar.color = ConsoleColor.Green;
                        newCar.x = randomGenerator.Next(0, playfielWidth); // Generira stoinost na "x" mejdu 0 i "playfieldWidth", koito e 5
                        newCar.y = 0;
                        newCar.c = '#';      // Simvol na novataa kolichka 
                        objects.Add(newCar); // Dobavqme q v spisaka s kolichki
                    }

                }

                if (Console.KeyAvailable)  // MEtod kojto proverqva dali potrebitelq e natisnal kopche, za da moje konsolata da ne chaka natiskateto na kopche
                {
                    ConsoleKeyInfo pressedKey = Console.ReadKey(true); // true v scobite zashtoto ni trqbva kopcheto a ne da izpisva tova, koeto sme natisnali

                    while (Console.KeyAvailable) //chistim bufera za natisnato kopche
                    {
                        Console.ReadKey(true);
                    }
                    
                    if (pressedKey.Key == ConsoleKey.UpArrow & bonusBullet > 0)
                    {
                        bonusBullet--;

                        Bullets.x = userCar.x;                         // izbirame Patron
                        Bullets.y = Console.WindowHeight - 1; // izbirame Patron
                        Bullets.c = '|';                     // kak izglejda Patron
                        Bullets.color = ConsoleColor.Green;
                        Bullet.Add(Bullets);
                                             
                    }

                    if (pressedKey.Key == ConsoleKey.LeftArrow)  // Ako natisnatoto kopche e strelka na lqvo
                    {
                        if (userCar.x - 1 >= 0) // novata stoinost da e do 0 ili nachalto na poleto
                        {
                            userCar.x = userCar.x - 1;
                        }

                    }
                    else if (pressedKey.Key == ConsoleKey.RightArrow)
                    {
                        if (userCar.x + 1 < playfielWidth) // novata stoinost da e po-malka ot goleminata na poleto
                        {
                            userCar.x = userCar.x + 1;
                        }
                    }
                }

                //if (Bullets.c == '|' && Bullets.y > 0)
               // {                 
                        Bullets.y--;
              //  } 
               // if (Bullets.y == 1)
              //  {
              //      Bullet.Remove(Bullets);
               // }
            


                List<Object> newBullet = new List<Object>();
                if (Bullets.c == '|')
                {                    
                //    Object 
                    Object newBullets = new Object();
                    newBullets.x = Bullets.x;
                    newBullets.y = Bullets.y - 1;
                    newBullets.c = Bullets.c;
                    newBullets.color = Bullets.color;
                   if (newBullets.y >= 0)
                    {
                        newBullet.Add(newBullets);
                    }
                }
                Bullet = newBullet;


                // Ako nqkoi obekt udari nashata kola
                List<Object> newList = new List<Object>();
                for (int i = 0; i < objects.Count; i++)
                {
                    Object oldCar = objects[i];
                    Object newObject = new Object();
                    newObject.x = oldCar.x;
                    newObject.y = oldCar.y + 1;
                    newObject.c = oldCar.c;
                    newObject.color = oldCar.color;

                    if (newObject.c == '?' && newObject.y == userCar.y && newObject.x == userCar.x)   // ako bonusa ni odari
                    {
                        bonusBullet++;
                    }

                    if (Bullets.c == '|' && newObject.c == '#' && Bullets.x == newObject.x && Bullets.y < newObject.y) //&& Bullets.y == newObject.y)
                    {
                        newObject.c = ' ';
                    }

                    if (newObject.c == '^' && newObject.y == userCar.y && newObject.x == userCar.x)   // ako bonusa ni odari
                    {
                        livesCount++;
                    }

                    if (newObject.c == '*' && newObject.y == userCar.y && newObject.x == userCar.x)   // ako bonusa ni odari
                    {
                        speed -= 20;
                    }

                    if (newObject.c == '#' && newObject.y == userCar.y && newObject.x == userCar.x) // Proverka dali kolichkata e blasnata. UMIRANE
                    {
                        livesCount--;

                        speed = speed + 20;

                        if (speed > 400)
                        {
                            speed = 400;
                        }

                        hitted = true;    // kazvame che e odarane nashtata kola

                        if (livesCount <= 0)
                        {
                            PrintStringOnPosition(8, 7, "GAMEOVER!!!", ConsoleColor.Red);
                            PrintStringOnPosition(8, 7, "PRESS [ENTER] TO EXIT", ConsoleColor.Red);
                            Console.ReadLine();
                            return;
                        }

                    }
                    if (newObject.y < Console.WindowHeight)
                    {
                        newList.Add(newObject);
                    }
                }
                objects = newList; // Kazvame na stariqt spisak "cars" da ima sashtite kolichki kato v noviq list



                // Izchisti konsolata
                Console.Clear();

                // Napisvane na informaciq

                PrintStringOnPosition(8, 4, "Lives: " + livesCount, ConsoleColor.White);
                PrintStringOnPosition(8, 5, "Buletss: " + bonusBullet, ConsoleColor.Green);
                PrintStringOnPosition(8, 6, "Speed: " + speed, ConsoleColor.White);
                PrintStringOnPosition(8, 7, "Acceleration: " + acceleration, ConsoleColor.White);

                // Chertane na kolite
                foreach (Object car in objects)    // Izpalnqva edno i sashto parche kod varhu elementite ot dedena kolekciq
                {
                    PrintOnPosition(car.x, car.y, car.c, car.color);
                }

                if (hitted)    // Ako sa ni udarili printirame "X", ako ne prodaljavame
                {
                    Console.Beep(); // Zvuk
                    objects.Clear();
                    PrintOnPosition(userCar.x, userCar.y, 'X', ConsoleColor.Red);   // pritira "X" kogato nashtat kola e udarena
                }
                else
                {
                    PrintOnPosition(userCar.x, userCar.y, userCar.c, userCar.color);
                }
                
                foreach (Object Bulletss in Bullet)
                {
                    PrintOnPosition(Bullets.x, Bullets.y, Bullets.c, Bullets.color);
                }
                

                // Zabavqna na izpalnennieto na programata              
                Thread.Sleep((int)(600 - speed));


                // http://www.youtube.com/watch?v=bQexyufgclY
            }

        }
    }
}
