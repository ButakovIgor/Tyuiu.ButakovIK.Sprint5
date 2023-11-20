﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ButakovIK.Sprint5.Task4.V13.Lib
{
    public class DataService : ISprint5Task4V13
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            double res = Math.Round(Math.Cos(Convert.ToDouble(strX)) + (Math.Pow(Convert.ToDouble(strX), 2) / 2), 3);
            return res;
        }
    }
}
