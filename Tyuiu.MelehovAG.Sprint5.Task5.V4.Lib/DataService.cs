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
                int i = 0;
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    double line2 = Convert.ToDouble(line);
                    i++;
                    if (i == 1)
                    {
                        res = line2; 
                    }
                    else
                    {
                        res = line2 * res; 
                    }
                    
                }
                return res;
                
            }
        }
    }
}
