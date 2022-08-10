using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgrammingProblems
{
    public static class LargestThreeNo
    {
        public static void LargestThreeNumber()
        {
            int num1, num2, num3, largest;
            Console.WriteLine("Enter the number 1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number 2");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number 3");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
                largest = num1;
            else if
                (num2 > num1 && num2 > num3)
                largest = num2;
            else
                largest = num3;

            Console.WriteLine("Largest Number among {0},{1} and {2} is {3},num1,num2,num3,largest");
            Console.ReadKey();
        }
    }
}
    
