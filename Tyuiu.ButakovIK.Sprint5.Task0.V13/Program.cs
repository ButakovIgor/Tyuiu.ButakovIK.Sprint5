using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ButakovIK.Sprint5.Task0.V13.Lib;

namespace Tyuiu.ButakovIK.Sprint5.Task0.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            
            Console.Title = "Спринт #5 | Выполнил: Бутаков И.К. | АСОиУБ-23-1";

            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* Спринт #5                                                                            *");
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                                     *");
            Console.WriteLine("* Таск #0                                                                              *");
            Console.WriteLine("* Вариaнт #13                                                                          *");
            Console.WriteLine("* Выполнил: Бутаков Игорь Константинович | АСОиУБ-23-1                                 *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                             *");
            Console.WriteLine("* Дано выражение F(x) = -1.4x^3 + 2.3x^2 + 0.6x, вычислить его значение при x = 5,     *");
            Console.WriteLine("* результат сохранить в текстовый файл и вывести на консоль.                           *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                     *");
            Console.WriteLine("****************************************************************************************");

            int x = 5;

            Console.WriteLine("x = " + x);

            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                           *");
            Console.WriteLine("****************************************************************************************");

            string res = ds.SaveToFileTextData(x);

            Console.WriteLine("Файл: " + res + " создан!");
            Console.ReadKey();
        }
    }
}
