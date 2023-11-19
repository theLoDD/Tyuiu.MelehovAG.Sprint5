using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MelehovAG.Sprint5.Task0.V0.Lib;

namespace Tyuiu.MelehovAG.Sprint5.Task0.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                       *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #0                                                              *");
            Console.WriteLine("* Выполнил: Мелехов Алексей Григорьевич | ПКТб-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("***************************************************************************");

            int a = -5;

            Console.WriteLine("a = " + a);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(a);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();

            /*
            string outputFile = "OutPutFileTask0.txt";
            double x10 = 5;
            double result10 = Math.Pow(x10, 4) - 4 * Math.Pow(x10, 3) + 6 * Math.Pow(x10, 2) - 8 * x10 + 10;
            File.AppendAllText(outputFile, result10.ToString());
            Console.WriteLine();
            Console.ReadKey();
            */
        }
    }
}
