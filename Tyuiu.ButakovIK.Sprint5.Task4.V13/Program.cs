using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.ButakovIK.Sprint5.Task4.V13.Lib;

namespace Tyuiu.ButakovIK.Sprint5.Task4.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Бутаков И.К. | АСОиУБ-23-1";

            Console.WriteLine("*****************************************************************************************");
            Console.WriteLine("* Спринт #5                                                                             *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                               *");
            Console.WriteLine("* Таск #4                                                                               *");
            Console.WriteLine("* Вариaнт #13                                                                           *");
            Console.WriteLine("* Выполнил: Бутаков Игорь Константинович | АСОиУБ-23-1                                  *");
            Console.WriteLine("*****************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                              *");
            Console.WriteLine("* Дан файл InPutDataFileTask4V13.txt. Создать папку в ручную и скопировать              *");
            Console.WriteLine("* в неё файл в котором есть вещественное значение. Прочитать значение из файла и        *");
            Console.WriteLine("* подставить вместо Х в формуле: y = cos(x) + x^2 / 2. Вычислить значение по формуле    *");
            Console.WriteLine("* и вернуть полученный результат на консоль.                                            *");
            Console.WriteLine("*****************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                      *");
            Console.WriteLine("*****************************************************************************************");

            string path = $@"{Directory.GetCurrentDirectory()}\InPutDataFileTask4V13.txt";

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
