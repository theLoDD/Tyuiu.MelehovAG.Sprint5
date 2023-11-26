using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MelehovAG.Sprint5.Task2.V30.Lib;
using System.IO;

namespace Tyuiu.MelehovAG.Sprint5.Task2.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл      *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Мелехов Алексей Григорьевич | ПКТб-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("***************************************************************************");

            int a;
            Console.Write("* Введите 1 число для матрицы 3 на 3: ");
            a = Convert.ToInt32(Console.ReadLine());

            int b;
            Console.Write("* Введите 2 число для матрицы 3 на 3: ");
            b = Convert.ToInt32(Console.ReadLine());

            int c;
            Console.Write("* Введите 3 число для матрицы 3 на 3: ");
            c = Convert.ToInt32(Console.ReadLine());

            int d;
            Console.Write("* Введите 4 число для матрицы 3 на 3: ");
            d = Convert.ToInt32(Console.ReadLine());

            int e;
            Console.Write("* Введите 5 число для матрицы 3 на 3: ");
            e = Convert.ToInt32(Console.ReadLine());

            int f;
            Console.Write("* Введите 6 число для матрицы 3 на 3: ");
            f = Convert.ToInt32(Console.ReadLine());

            int g;
            Console.Write("* Введите 7 число для матрицы 3 на 3: ");
            g = Convert.ToInt32(Console.ReadLine());

            int h;
            Console.Write("* Введите 8 число для матрицы 3 на 3: ");
            h = Convert.ToInt32(Console.ReadLine());

            int k;
            Console.Write("* Введите 9 число для матрицы 3 на 3: ");
            k = Convert.ToInt32(Console.ReadLine());

            /*
            int[,] mtrx = new int[3, 3]  { { 3, -1, -3},
                                           { -2, -5, 0},
                                           { -8, -7, 2} };*/
            int[,] mtrx = new int[3, 3]  { { a, b, c},
                                           { d, e, f},
                                           { g, h, k} }; 
            int rows = mtrx.GetUpperBound(0) + 1; // количество строк
            int columns = mtrx.Length / rows; // количество столбцов
                                              // или так  int columns = numbers.GetUpperBound(1) + 1;



            Console.WriteLine("Массив:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mtrx[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(mtrx);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();

        }
    }
}
