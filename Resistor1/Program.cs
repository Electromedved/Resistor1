using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

/*
5) Составить блок-схему алгоритма вычисления сопротивления электрической цепи, состоящей из двух сопротивлений.
Сопротивления могут быть соединены последовательно или параллельно.
*/

namespace Resistor1
{
    class Program
    {
        static void Main(string[] args)
        {
            float r1;
            float r2;
            int connection;
            float total;

            Console.WriteLine("Вычисление сопротивления электрической цепи.");
            Console.WriteLine("Введите исходные данные:");
            Console.Write("Величина первого сопротивления (Ом): "); r1 = float.Parse(Console.ReadLine().Replace(",", "."));
            Console.Write("Величина второго сопротивления (Ом): "); r2 = float.Parse(Console.ReadLine().Replace(",", "."));
            m1:
            Console.Write("Тип соединения (1 — последовательное, 2 — параллельное): "); connection = int.Parse(Console.ReadLine());

            if (connection == 1 || connection == 2)
            {
                if (connection == 1)
                {
                    total = r1 + r2;
                }
                else
                {
                    total = (r1 * r2) / (r1 + r2);
                }

                Console.WriteLine("-------------------------------------------");
                Console.WriteLine($"Сопротивление цепи: {total} Ом");
            }
            else
            {
                Console.WriteLine("Не выбран правильный тип соединения!");
                goto m1;
            }

            Console.ReadLine();
        }
    }
}
