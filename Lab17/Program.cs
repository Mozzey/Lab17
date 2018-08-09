using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab17.Library;

namespace Lab17
{
    class Program
    {
        static void Main(string[] args)
        {



            var primeGenerator = new PrimesGenerator();
            primeGenerator.FillList();
            Console.WriteLine("Let's locate some prime numbers!");
            Console.WriteLine();
            Console.WriteLine("This application will find you any prime, in order, from first prime number on.");

            do
            {
                Console.Write("Which prime number are you looking for? \n");
                int index = int.Parse(Console.ReadLine());

                for (int i = 1; i < primeGenerator.Count; i++)
                {
                    
                    if (index == i - 1)
                    {
                        Console.WriteLine($"The number {index} prime is {primeGenerator[index - 1]}\n");
                    }
                }
                Console.WriteLine("Would you like to lookup another prime number?");
            } while (RunProgram.PlayAgain(Console.ReadLine()));



            Console.ReadKey();
        }

        
    }
}
