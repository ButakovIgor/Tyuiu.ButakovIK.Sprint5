using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ButakovIK.Sprint5.Task3.V8.Lib;

namespace Tyuiu.ButakovIK.Sprint5.Task3.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Бутаков И.К. | АСОиУБ-23-1";

            Console.WriteLine("*****************************************************************************************");
            Console.WriteLine("* Спринт #5                                                                             *");
            Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                                   *");
            Console.WriteLine("* Таск #3                                                                               *");
            Console.WriteLine("* Вариaнт #8                                                                            *");
            Console.WriteLine("* Выполнил: Бутаков Игорь Константинович | АСОиУБ-23-1                                  *");
            Console.WriteLine("*****************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                              *");
            Console.WriteLine("* Дано выражение вычислить его значение при x = 3, результат сохранить в бинарный файл  *");
            Console.WriteLine("* OutPutFileTask3.bin и вывести на консоль. Округлить до трёх знаков после запятой.     *");
            Console.WriteLine("* y(x) = x^2 + 1 / 3x + 4                                                               *");
            Console.WriteLine("*****************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                      *");
            Console.WriteLine("*****************************************************************************************");

            int x = 3;
            Console.WriteLine("x = " + x);

            Console.WriteLine("*****************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТAТ:                                                                            *");
            Console.WriteLine("*****************************************************************************************");

            string res = ds.SaveToFileTextData(x);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
