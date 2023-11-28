using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MelehovAG.Sprint5.Task3.V23.Lib;
using System.IO;

namespace Tyuiu.MelehovAG.Sprint5.Task3.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                     *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнил: Мелехов Алексей Григорьевич | ПКТб-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("***************************************************************************");

            int a = 3;

            Console.WriteLine("a = " + a);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(a);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            
            using (FileStream fileStream = new FileStream(res, FileMode.Open))
            {
                using (BinaryReader binaryReader = new BinaryReader(fileStream))
                {
                    // Считываем данные из бинарного файла
                    //int intValue = binaryReader.ReadInt32();
                    double doubleValue = binaryReader.ReadDouble();
                    //string stringValue = binaryReader.ReadString();

                    Console.WriteLine("Прочитанные данные из бинарного файла:");
                    Console.WriteLine("double: " + doubleValue);
                    //Console.WriteLine("string: " + stringValue);
                }
            }
            Console.ReadKey();


        }
    }
}
