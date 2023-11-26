using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MelehovAG.Sprint5.Task2.V30.Lib;
using System.IO;

namespace Tyuiu.MelehovAG.Sprint5.Task2.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Иридий\source\repos\Tyuiu.MelehovAG.Sprint5\Tyuiu.MelehovAG.Sprint5.Task1.V6\bin\Debug\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
