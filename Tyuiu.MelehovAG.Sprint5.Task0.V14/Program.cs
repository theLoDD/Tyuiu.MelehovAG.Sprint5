﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MelehovAG.Sprint5.Task0.V14.Lib;
using System.IO;

namespace Tyuiu.MelehovAG.Sprint5.Task0.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Мелехов Алексей Григорьевич | ПКТб-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("***************************************************************************");

            int a = 3;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(a);

            string path_file = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";
            Console.WriteLine("Ответ: " + res);
            Console.WriteLine("Путь к файлу: " + path_file);
            Console.WriteLine("Файл создан!\n\n");
            Console.ReadKey();

        }
    }
}
