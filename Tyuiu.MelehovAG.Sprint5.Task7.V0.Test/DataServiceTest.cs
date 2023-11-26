using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.MelehovAG.Sprint5.Task7.V0.Lib;

namespace Tyuiu.MelehovAG.Sprint5.Task7.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]

        public void CheckExistsFile()
        {
            string path = @"C:\Users\Иридий\source\repos\Tyuiu.MelehovAG.Sprint5\Tyuiu.MelehovAG.Sprint5.Task7.V0\bin\Debug\InPutDataFileTask7V1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
