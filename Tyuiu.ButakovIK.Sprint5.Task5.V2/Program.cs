using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.ButakovIK.Sprint5.Task5.V2.Lib;

namespace Tyuiu.ButakovIK.Sprint5.Task5.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Бутаков И.К. | АСОиУБ-23-1";

            Console.WriteLine("*****************************************************************************************");
            Console.WriteLine("* Спринт #5                                                                             *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                                        *");
            Console.WriteLine("* Таск #5                                                                               *");
            Console.WriteLine("* Вариaнт #2                                                                            *");
            Console.WriteLine("* Выполнил: Бутаков Игорь Константинович | АСОиУБ-23-1                                  *");
            Console.WriteLine("*****************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                              *");
            Console.WriteLine("* Дан файл InPutDataFileTask5V2.txt Создать папку в ручную и скопировать                *");
            Console.WriteLine("* в неё файл в котором есть набор значений. Найти среднее всех положительных значений.  *");
            Console.WriteLine("* Полученный результат вывести на консоль. У вещественных значений округлить до трёх    *");
            Console.WriteLine("* знаков после запятой.                                                                 *");
            Console.WriteLine("*****************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                      *");
            Console.WriteLine("*****************************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask5V2.txt";

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("*****************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТAТ:                                                                            *");
            Console.WriteLine("*****************************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
