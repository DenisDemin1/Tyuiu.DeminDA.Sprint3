﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DeminDA.Sprint3.Task6.V6.Lib;


namespace Tyuiu.DeminDA.Sprint3.Task6.V6
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
            Console.WriteLine("* Тема:  Обработка целочисленной информации                               *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #6                                                             *");
            Console.WriteLine("* Выполнил: Дёмин Денис Александрович | ИИПБ-23-2                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет сумму ряда от суммы ряда          *");
            Console.WriteLine("*Напишите программу, которая ищет среди целых чисел, принадлежащих        *");
            Console.WriteLine("*числовому отрезку [16, 24] количество всех делителей больше 10           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = 16;
            int stopValue = 24;

            Console.WriteLine("* Начало отрезка = " +startValue);
            Console.WriteLine("* Конец отрезка = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Количество делителей = " +  ds.GetSumTheDivisors(startValue, stopValue));

            Console.ReadLine(); 







        }
    }
}
