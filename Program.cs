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
                Console.WriteLine("Введите число больше 0");
                return;
            }

            int length = 0;
            int temp_length = temp;
            while (temp_length > 0)
            {
                length++;
                temp_length /= 10;
            }

            int middleZero = length / 2;

            int zero = 0;

            int res = 0;

            int mnoj = 1;

            int currentPosition = 0;

            while (temp > 0)
            {
                int current = temp % 10;

                if (current != zero || current != middleZero)
                {
                    res += current * mnoj;
                    mnoj *= 10;
                }
                current++;
                temp /= 10;
                Console.WriteLine(res);
            }
            Console.WriteLine($"Результат: {res}");
        }
    }
}
