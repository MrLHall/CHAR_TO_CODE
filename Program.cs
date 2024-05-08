using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHAR_TO_CODE
{
    internal class Program
    {
        static int CHAR_TO_CODE(string a) //takes a as a perameter, this will be the users input
        {
            char letter = Convert.ToChar(a); // converts the inputted letter to a char
            return Convert.ToInt16(letter); //returns the ASCII value 
        }
        static void Main(string[] args)
        {
            
        }
    }
}
