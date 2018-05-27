using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static bool check_simple(int value)
        {
            bool flag = true;
            for (int i = 2; i <= value / 2; i++)
            {
                if (value % i == 0)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        static int find_simple(int value)
        {
            int s_next = value + 1;
            if (check_simple(value))
            {
                while (!check_simple(s_next))
                {
                    s_next += 1;
                }
                return s_next;
            }
            else return -1;
        }

        static int find_first(int ch)
        {
            bool fl = true;
            int s_first = 0;
            for (int i = 2; i <= ch / 2; i++)
            {
                if (ch % i == 0 && fl == true)
                {
                    s_first = i;
                    fl = false;
                    break;
                }
            }
            return s_first;
        }

        static int find_negative_first(int ch)
        {
            bool fl = true;
            int s_first = 0;
            for (int i = -2; i >= ch / 2; i--)
            {
                if (ch % i == 0 && fl == true)
                {
                    s_first = i;
                    fl = false;
                    break;
                }
            }
            return s_first;
        }


        static void Main(string[] args)
        {
            bool fl = true;
            int s_first = 0;
            int s_next = 0;
            int s_last = 0;

            Console.WriteLine("Введите число\n");
            int ch = int.Parse(Console.ReadLine());
            int first = 0;
            if (ch >= 0)
            {
                first = find_first(ch);
            }
            else
                first = find_negative_first(ch);
            s_first = Math.Abs(first);
            s_next = find_simple(s_first);
            if (ch % s_next == 0)
            {
                s_first = s_next;
            }
            s_last = find_simple(s_next);
            Console.Write("Ответ: ");
            if (ch % s_last == 0)
            {
                Console.Write("Да:  ");
                Console.Write(first+", ");
                Console.Write(s_next+", ");
                Console.WriteLine(s_last);
            }
            else Console.WriteLine("Нет.");
        }
    }
}
