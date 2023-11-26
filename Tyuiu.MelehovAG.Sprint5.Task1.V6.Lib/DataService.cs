using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.MelehovAG.Sprint5.Task1.V6.Lib
{
    public class DataService : ISprint5Task1V6
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            double y;
            string stringY;

            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Cos(x) + (4 * x / 2) - Math.Sin(x) * 3 * x;
                if (x != 0 && y / x == 0)
                {
                    stringY = Convert.ToString(y);
                }
                else
                {
                    File.AppendAllText(path, "0");
                    return path;
                }

                if (x != stopValue)
                {
                    File.AppendAllText(path, stringY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, stringY);
                }

            }
            return path;
        }
    }
}
