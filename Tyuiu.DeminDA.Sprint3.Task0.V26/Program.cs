using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DeminDA.Sprint3.Task0.V26.Lib;

namespace Tyuiu.DeminDA.Sprint3.Task0.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Дёмин Д.А. | ИИПБ-23-2";
            //Длина строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема:  Оператор цикла for                                               *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Дёмин Денис Александрович | ИИПБ-23-2                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл for, которая вычисляет произведение   *");
            Console.WriteLine("* ряда по формуле                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = 1;
            int stopValue = 9;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = Convert.ToDouble(ds.GetMultiplySeries(startValue, stopValue));
            Console.WriteLine(res);
            Console.ReadLine();



        }
    }
}
