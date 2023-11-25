using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.ButakovIK.Sprint5.Task7.V7.Lib;

namespace Tyuiu.ButakovIK.Sprint5.Task7.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckExistsFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask7V7.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }

        [TestMethod]
        public void CheckLoadDataAndSave()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask7V7.txt";
            string pathSaveFile = ds.LoadDataAndSave(path);
            string content = File.ReadAllText(pathSaveFile);
            string wait = "Hello, !  Is My First Program.";
            Assert.AreEqual(wait, content);
        }
    }
}
