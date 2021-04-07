using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Task1
    {
        static void Main(string[] args)
        {
            Console.Write("Вводите количество символов массива X ");
            int ArrCountX = Convert.ToInt32(Console.ReadLine());
            Console.Write("Вводите количество символов массива Y ");
            int ArrCountY = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();
            int[] arrayX = randomArr(ArrCountX, rand, 0, 10000);
            int[] arrayY = randomArr(ArrCountY, rand, 0, 10000);
            int minX = MinArr(arrayX);
            int minY = MinArr(arrayY);
            Console.WriteLine($"Разность между минимальными элементами равна {minX - minY}");
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
        static int MinArr(int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return (min);
        }
    }
}
