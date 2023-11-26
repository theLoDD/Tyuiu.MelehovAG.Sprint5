using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.MelehovAG.Sprint5.Task0.V14.Lib
{
    public class DataService : ISprint5Task0V14
    {
        public string SaveToFileTextData(int x)
        {

            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";
            double y = (double)x;
            y = (4 * Math.Pow(x, 3)) / (Math.Pow(x, 3) - 1);
            y = Math.Round(y, 3);
            string answer = y.ToString();
            File.WriteAllText(path, answer);
            return answer;
        }
    }
}
