using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17.Library
{
    public class RunProgram
    {
        public static bool PlayAgain(string input)
        {
            switch (input)
            {
                case "y":
                    return true;
                case "n":
                    return false;
                default:
                    Console.WriteLine("Not a valid input");
                    return PlayAgain(Console.ReadLine().ToLower());
            }
        }
    }
}
