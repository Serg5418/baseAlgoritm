using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
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

        static void Main(string[] args)
        {
            try
            {
                //задание 1
                Console.WriteLine("задание 1");
                Console.Write("Вводите количество символов массива X ");
                int ArrCountX = Convert.ToInt32(Console.ReadLine());
                Console.Write("Вводите количество символов массива Y ");
                int ArrCountY = Convert.ToInt32(Console.ReadLine());
                Random rand = new Random();
                int min = 0;
                int max = 10000;
                //int[] arrayX = randomArr(ArrCountX, rand, 0, 10000);
                int[] arrayX = new int[ArrCountX];

                for (int i = 0; i < arrayX.Length; i++)
                {
                    arrayX[i] = rand.Next(min, max);
                }

                // int[] arrayY = randomArr(ArrCountY, rand, 0, 10000);
                int[] arrayY = new int[ArrCountY];

                for (int i = 0; i < arrayY.Length; i++)
                {
                    arrayY[i] = rand.Next(0, 10000);
                }

                int minX = MinArr(arrayX);
                int minY = MinArr(arrayY);
                Console.WriteLine($"Разность между минимальными элементами равна {minX - minY}");
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("произошла ошибка");
            }
            //задание 2
            try
                {
                    Console.WriteLine("задание 2");
                    Random rand2 = new Random();
                    int[] arrayA = new int[20];

                    for (int i = 0; i < arrayA.Length; i++)
                    {
                        arrayA[i] = rand2.Next(-100, 100);
                    }

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
                        pB = pB * item;
                        Console.Write($"{item} ");
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine($"Количество положительных элементов: {arrayB.Length} ");
                    Console.WriteLine($"Произведение положительных элементов: {pB} ");
                    Console.ReadKey();
                }
                catch
                {
                    Console.WriteLine("произошла ошибка");
                }
                //задание 3
                try
                {
                    Console.WriteLine("задание 3");
                Console.Write("Введите текст ");
                string Text = Console.ReadLine();
                bool isValid = true;
                String[] elements = Text.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                if (elements.Length != 2)
                    isValid = false;
                if (elements[0].Length >= 2 && elements[0].Length <= 4)
                {
                    foreach (var k in elements[0])
                    {
                        if (!Char.IsLetter(k))
                            isValid = false;

                    }
                }
                else
                    isValid = false;

                string[] rightText = elements[1].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (rightText.Length == 1)
                {
                    if (rightText[0].Length == 3)
                    {
                        foreach (var j in rightText[0])
                        {
                            if (!Char.IsNumber(j))
                                isValid = false;
                        }

                    }
                    else if (rightText[0].Length == 4)
                    {
                        string a = rightText[0].Substring(0, 3);
                        string b = rightText[0].Substring(rightText[0].Length - 1);
                        foreach (var j in a)
                        {
                            if (!Char.IsNumber(j))
                                isValid = false;
                        }
                        if (!Char.IsLetter(Convert.ToChar(b)))
                            isValid = false;
                    }
                    else if (rightText[0].Length == 5)
                    {
                        string a = rightText[0].Substring(0, 3);
                        string b = rightText[0].Substring(rightText[0].Length - 2);
                        foreach (var j in a)
                        {
                            if (!Char.IsNumber(j))
                                isValid = false;
                        }
                        foreach (var j in b)
                        {
                            if (!Char.IsLetter(j))
                                isValid = false;
                        }
                    }
                    else
                        isValid = false;
                }
                else if (rightText.Length == 2)
                {
                    if (rightText[1].Length >= 2 && rightText[1].Length <= 4)
                    {
                        foreach (var j in rightText[1])
                        {
                            if (!Char.IsLetter(j))
                                isValid = false;
                        }
                    }
                    else
                        isValid = false;
                }
                else
                    isValid = false;

                if (isValid == true)
                {
                    Console.WriteLine("Данная запись является номером группы");
                }
                else
                {
                    Console.WriteLine("Данная запись не является номером группы");
                }
            }
            catch
            {
                Console.WriteLine("Данная запись не является номером группы");
            }
          
            Console.ReadKey();
        }
    }
}
