using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console
{
    class Program
    {
        private static void Main()
        {
            // Исходная строка .
            string str = @"1*y '' - 1* y'-=0";
            // Убираем пробелы.
            str = str.Replace(" ", string.Empty);
            int a = 0;
            int b = 0;
            int pos = 0;
            if (Check(str, ref a, ref b, ref pos))
            {
                Console.WriteLine("Выражение подходит, коэффициенты: a={0}, b={1}", a, b);
            }
            else
            {
                Console.WriteLine("Ошибка в записи выражения в позиции {0}", pos);
            }
            Console.ReadKey();
        }

        private static bool Check(string str, ref int a, ref int b, ref int pos)
        {
            // Номер состояния конечного автомата.
            int condition = 0;
            // Коэффициенты уравнения.
            int signa = 1;
            int signb = 1;
            a = 0;
            b = 0;
            // Проходим по всем символам строки.
            pos = 0;
            foreach (char c in str)
            {
                pos++;
                switch (condition)
                {
                    case 0:
                        if (char.IsLetter(c))
                        {
                            condition = 1;
                            break;
                        }
                        return false;
                    case 1:
                        if (char.IsLetter(c))
                        {
                            condition = 1;
                            break;
                        }
                        if (c == '\'')
                        {
                            condition = 2;
                            break;
                        }
                        return false;
                    case 2:
                        if (c == '\'')
                        {
                            condition = 3;
                            break;
                        }
                        return false;
                    case 3:
                        if (c == '+')
                        {
                            condition = 4;
                            signa = 1;
                            break;
                        }
                        if (c == '-')
                        {
                            condition = 4;
                            signa = -1;
                            break;
                        }
                        return false;
                    case 4:
                        if (char.IsDigit(c))
                        {
                            condition = 5;
                            a = int.Parse(c.ToString());
                            break;
                        }
                        return false;
                    case 5:
                        if (char.IsDigit(c))
                        {
                            condition = 5;
                            a = a * 10 + int.Parse(c.ToString());
                            break;
                        }
                        if (c == '*')
                        {
                            condition = 6;
                            break;
                        }
                        return false;
                    case 6:
                        if (char.IsLetter(c))
                        {
                            condition = 7;
                            break;
                        }
                        return false;
                    case 7:
                        if (char.IsLetter(c))
                        {
                            condition = 7;
                            break;
                        }
                        if (c == '\'')
                        {
                            condition = 8;
                            break;
                        }
                        return false;
                    case 8:
                        if (c == '+')
                        {
                            condition = 9;
                            signb = 1;
                            break;
                        }
                        if (c == '-')
                        {
                            condition = 9;
                            signb = -1;
                            break;
                        }
                        return false;
                    case 9:
                        if (char.IsDigit(c))
                        {
                            condition = 10;
                            b = int.Parse(c.ToString());
                            break;
                        }
                        return false;
                    case 10:
                        if (char.IsDigit(c))
                        {
                            condition = 10;
                            b = 10 * b + int.Parse(c.ToString());
                            break;
                        }
                        if (c == '=')
                        {
                            condition = 11;
                            break;
                        }
                        return false;
                    case 11:
                        if (c == '0')
                        {
                            condition = 12;
                            break;
                        }
                        return false;
                    default:
                        return false;
                }
            }
            a = a * signa;
            b = b * signb;
            return true;
        }
    }
}
