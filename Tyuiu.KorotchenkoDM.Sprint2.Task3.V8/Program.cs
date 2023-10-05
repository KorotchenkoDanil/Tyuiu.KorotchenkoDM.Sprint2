using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KorotchenkoDM.Sprint2.Task3.V8.Lib;

namespace Tyuiu.KorotchenkoDM.Sprint2.Task3.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Коротченко Д. М. | ИСТНб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Вложенные операторы if-else                                       *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Коротченко Данил Михайлович | ИСТНб-23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y с    *");
            Console.WriteLine("* использованием вложенных операторов if-else, где пользователь вводит    *");
            Console.WriteLine("* значение переменной X с клавиатуры. Округлить полученное значение до    *");
            Console.WriteLine("* трех знаков после запятой                                               *");
            Console.WriteLine("\n*      | sinx + cosx                                                      *");
            Console.WriteLine("*     | -------------, если x > 0                                         *");
            Console.WriteLine("*     |  cosx - sinx                                                      *");
            Console.WriteLine("*     |                                                                   *");
            Console.WriteLine("*     |  x^2 - cosx^2 + 10                                                *");
            Console.WriteLine("*     | -------------------, если x = 0                                   *");
            Console.WriteLine("*     |  x^2 - sinx^2 + 12                                                *");
            Console.WriteLine("* y = |                                                                   *");
            Console.WriteLine("*     |  (      3  )^x                                                    *");
            Console.WriteLine("*     |  (1 + -----)   , если -12 < x < 0                                 *");
            Console.WriteLine("*     |  (     x^2 )                                                      *");
            Console.WriteLine("*     |                                                                   *");
            Console.WriteLine("*     |            ( 5 )                                                  *");
            Console.WriteLine("*     |  x + 10x - (---), если x < -12                                    *");
            Console.WriteLine("*      |           ( x )                                                  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение переменной Х:                                             ");
            double x = Convert.ToDouble(Console.ReadLine());
            DataService ds = new DataService();
            double res = ds.Calculate(x);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Значение функции = " + res);

            Console.ReadKey();
        }
    }
}
