using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgrammingProblems
{
    public class VowelOrConstants
    {
        public static void CheckVowels()
        {
            Console.Write("Please enter an alphabet:  ");
            char ch = Convert.ToChar(Console.ReadLine());

            bool lowerCase = (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u');
            bool upperCase = (ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U');
            if (lowerCase || upperCase)
            {
                Console.WriteLine("\n\n'{0}' is a vowel", ch);
            }
            else
            {
                Console.WriteLine("\n\n'{0}' is a consonant", ch);
            }
        }
    }
}

