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
            return Num.All(x => Int32.TryParse(x.ToString(), out Int32 result) || x == ',' || x == '-' || x == '0');
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
            while (true) 
            {
                Console.WriteLine("1) Вывести значения функции.\n2)Выход.");
                string n = Console.ReadLine();
                bool end = false; ;
                if (CheckForInt(n)) 
                {
                    switch (Convert.ToInt32(n)) 
                    {
                        case 1:
                            for (double a = -7; a <= 4; a += 0.1)
                            {
                                    double b = a;
                                    if (b >= -7 && b < -3)
                                    {
                                        Console.WriteLine($"Значение функции: f({a:0.0}) = {fun1(b):0.00}\n");
                                    }
                                    else if (b >= -3 && b < -2)
                                    {
                                        Console.WriteLine($"Значение функции: f({a:0.0}) = {fun2(b):0.00}\n");
                                    }
                                    else if (b >= -2 && b < 2)
                                    {
                                        Console.WriteLine($"Значение функции: f({a:0.0}) = {fun3(b):0.00}\n");
                                    }
                                    else if (b >= 2 && b <= 4)
                                    {
                                        Console.WriteLine($"Значение функции: f({a:0.0}) = {fun4(b):0.00}\n");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Введёное вами число не попадает в область определения функции.");
                                    }                                
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
