using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {                                                             // You can use Console.ReadLine() operator
                StreamReader myReader = new StreamReader("Values1.txt"); // <- Name of the file Values.txt is the problem
                string line = "";

                while (line != null)
                {
                    line = myReader.ReadLine();
                    if (line != null)
                    {
                        Console.WriteLine(line);
                    }
                }

                myReader.Close();
                Console.ReadLine();
            }
            catch (FileNotFoundException)   // <- Specific type exception
            {
                Console.WriteLine("The file could not be found. Are you sure you're looking for th right file?");
            }
            catch (Exception e)
            {
                Console.WriteLine("We are having a problem {0}", e.Message);
            }
            finally
            {
                Console.WriteLine("why");
            }
        }
    }
}
