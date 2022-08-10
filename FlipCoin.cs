using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipTheCoins
{
    public class FlipCoin
    {
        public static void CalculatePer()
        {
            int headCount = 0;
            int tailCount = 0;
            double headPer;
            double tailPer;

            Console.WriteLine("Please enter the value for number of flip ");
            int flipCoin=Convert.ToInt32(Console.ReadLine());

            if (flipCoin>0)
            {
                for (int i = 0; i < flipCoin; i++)
                {
                    Random random = new Random();
                    int Number = random.Next(2);

                    Console.WriteLine("The flip is" + Number);

                    if (Number == 1)
                    {
                        headCount++;
                    }
                    else
                    {
                        tailCount++;
                    }
                }

                headPer = headCount * 100 / flipCoin;
                tailPer = tailCount * 100 / flipCoin;

                Console.WriteLine("The Head Percentage is" + headPer);
                Console.WriteLine("The tail percentage" + tailPer);
            }
        }
    }
}

