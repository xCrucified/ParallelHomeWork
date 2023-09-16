using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Bob
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb = 6;
            Parallel.Invoke(() => FactNumb(numb), () => FindLength(numb), () => FindSum(numb));
        }
        static void FactNumb(int x)
        {
            int result = 1;
            for (int i = 1; i <= x; i++)
            {
                result *= i;
            }
            Console.WriteLine($"Factorial {x} equals {result}");
        }
        static void FindLength(int x)
        {
            int count = 0;
            for (int i = 0; i <= x - 1; i++)
            {
                count++;
            }
            Console.WriteLine($"Count of numbers in: {x} equals: {count}");
        }

        static void FindSum(int num)
        {
            int sum = 0;
            for (int i = 1;i <= num; i++)
            {
                sum += num * i;
            }
            Console.WriteLine($"Sum of all numbers {sum}");
        }
    }
}