using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Task2
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] arrayA = randomArr(20, rand, -100, 100);
            List<int> listB = new List<int>();
            Console.Write("Массив A ");
            foreach (var item in arrayA)
            {
                if (item > 0)
                {
                    listB.Add(item);
                }
                Console.Write($"{item} ");
            }
            int[] arrayB = listB.ToArray();
            Console.WriteLine(" ");
            Console.Write("Массив B ");
            int pB = 1;
            foreach (var item in arrayB)
            {
                pB *= item;
                Console.Write($"{item} ");
            }
            Console.WriteLine(" ");
            Console.WriteLine($"Количество положительных элементов: {arrayB.Length} ");
            Console.WriteLine($"Произведение положительных элементов: {pB} ");
            Console.ReadKey();
        }
        static int[] randomArr(int Length, Random rand, int min, int max)
        {
            int[] array = new int[Length];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(min, max);
            }
            return (array);
        }
    }
}
