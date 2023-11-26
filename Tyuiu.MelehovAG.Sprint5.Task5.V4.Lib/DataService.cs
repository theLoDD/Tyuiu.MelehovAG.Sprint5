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
                string line;
                int i = 1;
                while ((line = reader.ReadLine()) != null)
                {
                    res = res * Convert.ToDouble(line);
                }
            }
            return res;
        }
    }
}
