using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static bool CheckForDouble(String Num)
        {
            return Num.All(x => Int32.TryParse(x.ToString(), out Int32 result) || x == ',' || x == '-');
        }
        static bool CheckForInt(String Num)
        {
            return Num.All(x => Int32.TryParse(x.ToString(), out Int32 result) && ( x == '1' || x == '2'));
        }
        static double fun1(double Num)
        {
            double f = Num + 7;
            return f;
        }
        static double fun2(double Num)
        {
            return 4;
        }
        static double fun3(double Num)
        {
            double f = Math.Pow(Num, 2);
            return f;
        }
        
        static double fun4 (double Num)
        {
            double f = 8 - 2 * Num;
            return f;
        }
        static void Main(string[] args)
        {
            String a;
            while (true) 
            {
                Console.WriteLine("1) Ввести X.\n2)Выход.");
                string n = Console.ReadLine();
                bool end = false; ;
                if (CheckForInt(n)) 
                {
                    switch (Convert.ToInt32(n)) 
                    {
                        case 1:
                            a = Console.ReadLine();
                            if (CheckForDouble(a))
                            {
                                double b = Convert.ToDouble(a);
                                if (b >= -7 && b < -3)
                                {
                                    Console.WriteLine($"Значение функции: {fun1(b)}");
                                }
                                else if (b >= -3 && b < -2)
                                {
                                    Console.WriteLine($"Значение функции: {fun2(b)}");
                                }
                                else if (b >= -2 && b < 2)
                                {
                                    Console.WriteLine($"Значение функции: {fun3(b)}");
                                }
                                else if (b >= 2 && b <= 4)
                                {
                                    Console.WriteLine($"Значение функции: {fun4(b)}");
                                }
                                else
                                {
                                    Console.WriteLine("Введёное вами число не попадает в область определения функции.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Введите число или используйте запятую, а не точку");
                            }
                            break;
                        case 2:
                            end = true;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Выберите опцию меню.");
                }
                if (end)
                {
                    break;
                }
            }
        }
    }
}
