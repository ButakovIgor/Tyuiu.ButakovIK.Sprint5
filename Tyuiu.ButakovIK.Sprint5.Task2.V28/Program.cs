using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ButakovIK.Sprint5.Task2.V28.Lib;

namespace Tyuiu.ButakovIK.Sprint5.Task2.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Бутаков И.К. | АСОиУБ-23-1";

            Console.WriteLine("*****************************************************************************************");
            Console.WriteLine("* Спринт #5                                                                             *");
            Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл                    *");
            Console.WriteLine("* Таск #2                                                                               *");
            Console.WriteLine("* Вариaнт #28                                                                           *");
            Console.WriteLine("* Выполнил: Бутаков Игорь Константинович | АСОиУБ-23-1                                  *");
            Console.WriteLine("*****************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                              *");
            Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов, заполненный значениями с         *");
            Console.WriteLine("* клавиатуры. Заменить положительные элементы массива на 1, отрицательные на 0.         *");
            Console.WriteLine("* Результат сохранить в файл OutPutFileTask2.csv и вывести на консоль.                  *");
            Console.WriteLine("*****************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                      *");
            Console.WriteLine("*****************************************************************************************");

            Console.WriteLine("Введите количество строк в массиве: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов в массиве: ");
            int columns = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Введите {i}, {j} элемент массива: ");
                    array[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }
            Console.WriteLine("\nМассив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{array[i, j]} \t ");
                }

                Console.WriteLine();
            }
            Console.WriteLine("Новый массив: ");
            Console.WriteLine("*****************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                            *");
            Console.WriteLine("*****************************************************************************************");

            string res = ds.SaveToFileTextData(array);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();


        }
    }
}
