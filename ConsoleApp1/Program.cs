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
            List<int> list = new List<int>() { 5, 7, 3, 2, 7, 8, 9, 10 };
            //Parallel.ForEach<int>(new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 },
            ParallelLoopResult plr = Parallel.ForEach<int>(list, FactNumb);
            Parallel.Invoke(() => FactNumb(2), () => FindLenght(list));
        }
        static void FactNumb(int x)
        {
            int result = 1;
            for (int i = 1; i <= x; i++)
            { 
                result *= i;
                
            }
            Console.WriteLine($"Factorial of {x} equals {result}");
        }
        static void FindLenght<T>(List<T> list)
        {
            int numbsCount = NumbsCount(list);
            Console.WriteLine(numbsCount);
            
        }

        private static int NumbsCount<T>(List<T> list)
        {
            return list.AsParallel().Count();
        }
    }
}