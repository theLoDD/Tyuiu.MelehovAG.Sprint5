using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.MelehovAG.Sprint5.Task2.V30.Lib
{
    public class DataService : ISprint5Task2V30
    {
        public string SaveToFileTextData(int[,] matrix)
        {

            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask2.csv";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        matrix[i, j] = 0;
                    } else {
                        matrix[i, j] = 1;
                    }
                }
            }

            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + matrix[i, j] + ";";
                    }
                    else
                    {
                        str = str + matrix[i, j];
                    }
                }

                if (i != rows - 1)
                {
                    File.AppendAllText(path, str + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, str);
                }

                str = "";
            }
            return path;
        }
    }
}
