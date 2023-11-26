using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MelehovAG.Sprint5.Task7.V1.Lib;
using System.IO;

namespace Tyuiu.MelehovAG.Sprint5.Task7.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]

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
