using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.Text.RegularExpressions;

namespace Tyuiu.ButakovIK.Sprint5.Task7.V7.Lib
{
    public class DataService : ISprint5Task7V7
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = @"C:\Users\t4w3r\source\repos\Tyuiu.ButakovIK.Sprint5\Tyuiu.ButakovIK.Sprint5.Task7.V7\bin\Debug\OutPutDataFileTask7V7.txt";
            string outText = "";
            string pattern = "[А-ЯЁ]";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                    outText += Regex.Replace(line, pattern, "");
            }
            File.WriteAllText(pathSaveFile, outText);
            return pathSaveFile;
        }
    }
}
