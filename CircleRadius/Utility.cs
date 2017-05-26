using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleRadius
{
    class Utility
    {
        public static double VerifyRadius()
        {
            double num = 0;
            bool valid = false;
            while (!valid)
            {
                try
                {
                    num = Convert.ToDouble(Console.ReadLine());
                    if (num > 0) {
                        valid = true;
                    } else
                    {
                        throw new ArgumentException();
                    }

                }
                catch
                {
                    Console.WriteLine("Please enter a Number (higher than zero).");
                }
            }
            return num;
        }

        public static int VerifyInteger()
        {
            int choice = 0;
            bool valid = false;
            while (!valid)
            {
                try
                {
                    choice = Convert.ToInt16(Console.ReadLine());
                    valid = true;
                }
                catch
                {
                }
            }
            return choice;
        }
    }
}
