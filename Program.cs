using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace kirichenko_pr5_var11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Введите число: ");
            n = Convert.ToInt32(Console.ReadLine());

            int temp = Math.Abs(n);

            if (temp == 0)
            {
                Console.WriteLine($"Результат: 0");
                return;
            }

            int length = 0;
            int temp_length = temp;
            while (temp_length > 0)
            {
                length++;
                temp_length /= 10;
            }

            int res = 0;

            int mnoj = 1;

            int currentPosition = 0;

            while (temp > 0)
            {
                int current = temp % 10;

                if (current != 0 || (length % 2 != 0 && currentPosition == length /2))
                {
                    res += current * mnoj;
                    mnoj *= 10;
                }
                currentPosition++;
                temp /= 10;
            }
            Console.WriteLine($"Результат: {res}");
        }
    }
}
