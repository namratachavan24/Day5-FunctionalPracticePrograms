using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgrammingProblems
{
        public static class LeapYear
        {
              public static void display()
              {
                 int CheckYear;

                 Console.WriteLine("Enter Year : ");
                 CheckYear = Convert.ToInt32(Console.ReadLine());

                 if ((CheckYear % 400) == 0)
                    Console.WriteLine("{0} is a leap year.\n", CheckYear);

                 else if ((CheckYear % 100) == 0)
                    Console.WriteLine("{0} is not a leap year.\n", CheckYear);

                 else if ((CheckYear % 4) == 0)
                    Console.WriteLine("{0} is a leap year.\n", CheckYear);

                 else
                    Console.WriteLine("{0} is not a leap year.\n", CheckYear);
              }
        }
    
}

