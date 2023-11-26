using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

using Tyuiu.MelehovAG.Sprint5.Task6.V0.Lib;

namespace Tyuiu.MelehovAG.Sprint5.Task6.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\Иридий\source\repos\Tyuiu.MelehovAG.Sprint5\Tyuiu.MelehovAG.Sprint5.Task6.V30\bin\Debug\InPutDataFileTask6V30.txt";

            var res = ds.LoadFromDataFile(path);
            int wait = 0;
            Assert.AreEqual(wait, res);
        }
        public void CheckExistsFile()
        {
            string path = @"C:\Users\Иридий\source\repos\Tyuiu.MelehovAG.Sprint5\Tyuiu.MelehovAG.Sprint5.Task6.V30\bin\Debug\InPutDataFileTask6V30.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
