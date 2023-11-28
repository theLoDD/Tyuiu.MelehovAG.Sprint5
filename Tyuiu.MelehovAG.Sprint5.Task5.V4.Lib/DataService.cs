using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.MelehovAG.Sprint5.Task5.V4.Lib
{
    public class DataService : ISprint5Task5V4
    {
        public double LoadFromDataFile(string path)
        {

            double res = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                
                int i = 1;
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    double line2 = Convert.ToDouble(line);
                    if (i == 1)
                    {
                        Console.WriteLine("Прогон " + i + ". Число: = " + line2);
                        res = Math.Round(line2, 3);
                        Console.WriteLine("Прогон " + i + ". Результат: = " + res + "\n");
                    } else
                    {
                        Console.WriteLine("Прогон " + i + ". Число: = " + line2);
                        Console.WriteLine("Прогон " + i + ". Прошлый результат: = " + res);
                        res = Math.Round(line2, 3) * res;
                        Console.WriteLine("Прогон " + i + ". Текущий результат: = " + res + "\n");
                    }

                    i++;

                }
                return res;
                
            }
        }
    }
}
