using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ButakovIK.Sprint5.Task1.V12.Lib;

namespace Tyuiu.ButakovIK.Sprint5.Task1.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

          

            Console.Title = "Спринт #5 | Выполнил: Бутаков И.К. | АСОиУБ-23-1";

            Console.WriteLine("*****************************************************************************************");
            Console.WriteLine("* Спринт #5                                                                             *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                               *");
            Console.WriteLine("* Таск #1                                                                               *");
            Console.WriteLine("* Вариaнт #12                                                                           *");
            Console.WriteLine("* Выполнил: Бутаков Игорь Константинович | АСОиУБ-23-1                                  *");
            Console.WriteLine("*****************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                              *");
            Console.WriteLine("* Дана функция, F(x) = (5x + 2.5 / sin(x) - 2) + 2 (произвести табулирование) F(x) на   *");
            Console.WriteLine("* заданном диапозоне [-5;5] с шагом 1. Произвести проверку деления на 0. При делении на *");
            Console.WriteLine("* ноль вернуть значение 0. Результат сохранить в текстовый файл и вывести на консоль.   *");
            Console.WriteLine("*****************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                      *");
            Console.WriteLine("*****************************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Начало: " + startValue);
            Console.WriteLine("Конец: " + stopValue);

            Console.WriteLine("*****************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                            *");
            Console.WriteLine("*****************************************************************************************");

            string res = ds.SaveToFileTextData(startValue, stopValue);
            
            

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
