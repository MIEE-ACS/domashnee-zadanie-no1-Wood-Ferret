using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Дз_1
{
    class Program
    {
        static void Main()
        {
            const double Pi = 3.14;

            Console.WriteLine("Введите длину окружности L: ");
            int n = 0;

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out n))//проверка значения
                {
                    if (n > 0)
                    {
                        break;
                    }
                    else Console.WriteLine("L должен быть положительным числом");
                }
            }
            try
            {
                double L = Convert.ToDouble(Console.ReadLine());

                double R = L / (2 * Pi);
                Console.WriteLine(String.Format(" Радиус: {0:F3} \n Площадь: {1:F3}", R, Pi * R * R));

            }
            catch (FormatException e)
            {
                Console.Error.WriteLine("Длина окружности введена неверно, введите число ");
            }
        }
    }
}