using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Task3
    {
        static void Main(string[] args)
        {
            Console.Write("Введите текст ");
            string Text = Console.ReadLine();
            Console.WriteLine(IsGroup(Text));
            Console.ReadKey();
        }
        static bool IsGroup(string Text)
        {
            String[] elements = Text.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            if (elements.Length != 2)
                return false;
            if (elements[0].Length >= 2 && elements[0].Length <= 4)
            {
                foreach (var k in elements[0])
                {
                    if (!Char.IsLetter(k))
                        return false;

                }
            }
            else
                return false;

            string[] rightText = elements[1].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (rightText.Length == 1)
            {
                if (rightText[0].Length == 3)
                {
                    foreach (var j in rightText[0])
                    {
                        if (!Char.IsNumber(j))
                            return false;
                    }

                }
                else if (rightText[0].Length == 4)
                {
                    string a = rightText[0].Substring(0, 3);
                    string b = rightText[0].Substring(rightText[0].Length - 1);
                    foreach (var j in a)
                    {
                        if (!Char.IsNumber(j))
                            return false;
                    }
                    if (!Char.IsLetter(Convert.ToChar(b)))
                        return false;
                }
                else if (rightText[0].Length == 5)
                {
                    string a = rightText[0].Substring(0, 3);
                    string b = rightText[0].Substring(rightText[0].Length - 2);
                    foreach (var j in a)
                    {
                        if (!Char.IsNumber(j))
                            return false;
                    }
                    foreach (var j in b)
                    {
                        if (!Char.IsLetter(j))
                            return false;
                    }
                }
                else
                    return false;
            }
            else if (rightText.Length == 2)
            {
                if (rightText[1].Length >= 2 && rightText[1].Length <= 4)
                {
                    foreach (var j in rightText[1])
                    {
                        if (!Char.IsLetter(j))
                            return false;
                    }
                }
                else
                    return false;
            }
            else
                return false;

            return true;
        }
    }
}
