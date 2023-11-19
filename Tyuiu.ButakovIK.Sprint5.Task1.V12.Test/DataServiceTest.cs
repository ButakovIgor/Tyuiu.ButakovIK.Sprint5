using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.ButakovIK.Sprint5.Task1.V12.Lib;

namespace Tyuiu.ButakovIK.Sprint5.Task1.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckExistsFile()
        {
            string path = @"C:\Users\t4w3r\source\repos\Tyuiu.ButakovIK.Sprint5\Tyuiu.ButakovIK.Sprint5.Task1.V12\bin\Debug\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
