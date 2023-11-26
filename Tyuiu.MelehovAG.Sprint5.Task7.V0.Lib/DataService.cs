using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.MelehovAG.Sprint5.Task7.V0.Lib
{
    public class DataService : ISprint5Task7V0
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = $@"C:\DataSprint5\OutPutDataFileTask7V1.txt";

            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }

            string strLine = "";

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if((line[i] != '*') && (line[i] != '+') && (line[i] != '-') && (line[i] != '/'))
                        {
                            strLine = strLine + line[i];
                        }

                    }
                    File.AppendAllText(pathSaveFile, strLine + Environment.NewLine);
                    strLine = "";
                }
            }

            return pathSaveFile;

        }
    }
}
