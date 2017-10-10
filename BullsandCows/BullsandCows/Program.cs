using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BullsandCows
{
    class Program
    {
        static void Main(string[] args)
        {
            string secrectNum = Console.ReadLine();
            int targetBulls = int.Parse(Console.ReadLine());
            int targetCows = int.Parse(Console.ReadLine());

            const char usedSecretNum = '*';
            const char usedGuessNum = '@';

            List<int> results = new List<int>();



            for (int num = 1000; num <= 9999; num++) // proverqvame vsi4ki 4ri chifreni chisla
            {
                int countFoundBulls = 0;
                int countFoundCows = 0;
                char[] digitsGuess = num.ToString().ToCharArray();    // Vzemame cifrite na chisloto, koeto proverqvame kato charove
                char[] secrectNumDigits = secrectNum.ToCharArray();   // Pravim na charove nashto chislo
                
                if (digitsGuess[0] >= '1' && digitsGuess[1] >= '1' && digitsGuess[2] >= '1' 
                    && digitsGuess[3] >= '1')
                {



                    //Za bikovete
                    for (int i = 0; i < digitsGuess.Length; i++) // proverqvame do daljinata na chisloto
                    {
                        if (digitsGuess[i] == secrectNumDigits[i]) // proverqvame vsqka cifra po neinata poziciq dali e ednakva s tazi na ekvivalentnataa poziciq v secretnoto ni chislo
                        {
                            countFoundBulls++;      // Ako e ednakva se pishe kato bik
                            digitsGuess[i] = usedGuessNum;         // premahvame chisloto ot proverkata kato go smenqme s konstantata
                            secrectNumDigits[i] = usedSecretNum;
                        }
                    }


                    // za kravite, kato parvata cifra na secretnoto chilo q proverqvame s vs chifri na nashteto chilo
                    for (int secretIndex = 0; secretIndex < digitsGuess.Length; secretIndex++) // proverqvame za kravi
                    {
                        for (int guessIndex = 0; guessIndex < digitsGuess.Length; guessIndex++)
                        {
                            if (secrectNumDigits[secretIndex] == digitsGuess[guessIndex]) 
                            {
                                countFoundCows++;
                                digitsGuess[guessIndex] = usedGuessNum;
                                secrectNumDigits[secretIndex] = usedSecretNum;
                            }
                        }
                    }






                    if (countFoundCows == targetCows && countFoundBulls == targetBulls)
                    {
                        results.Add(num);  // Ako chiloto otgovovarq na uslovieto go dobavqme
                    }
                }
            }






            if (results.Count == 0) // Ako ne sme namerili reshenie
            {
                Console.WriteLine("No");
            }
            else
            {
                for (int i = 0; i < results.Count; i++)
                {
                    Console.WriteLine(results[i] +" ");
                }
            }
        }
    }
}
