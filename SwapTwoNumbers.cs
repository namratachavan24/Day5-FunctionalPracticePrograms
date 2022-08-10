using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgrammingProblems
{
    public class SwapTwoNumbers
    {
        public static void SwapTwoNum()
        {
            int x = 5, y = 10;

            Console.WriteLine("Before swap x= " + x + " y= " + y);

            x = x * y;
            y = x / y;
            x = x / y;

            Console.Write("After swap x= " + x + " y= " + y);
        }
    }
}
