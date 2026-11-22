using System;
using System.IO;
using Tyuiu.ReneDS.Sprint5.Task2.V5.Lib;

namespace Tyuiu.ReneDS.Sprint5.Task2.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Ренье Д. С. | АСОиУБ-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Запись структурированных данных в текстовый файл                                       *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Ренье Дмитрий Сергеевич | АСОиУБ-26-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Ввести целочисленный массив 3 на 3 и заменить нечётные элементы на 0.   *");
            Console.WriteLine("* Сохранить результат в OutPutFileTask2.csv и вывести его на консоль.     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] matrix = new int[3, 3];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    int value;

                    while (true)
                    {
                        Console.Write($"Элемент [{row + 1}, {column + 1}] = ");
                        string input = Console.ReadLine();

                        if (input == null)
                        {
                            return;
                        }

                        if (int.TryParse(input, out value))
                        {
                            break;
                        }

                        Console.WriteLine("Введите целое число.");
                    }

                    matrix[row, column] = value;
                }
            }

            string debugDirectory =
                @"C:\Users\Пользователь\source\repos\Tyuiu.ReneDS.Sprint5\Tyuiu.ReneDS.Sprint5.Task2.V5\bin\Debug";

            string path = ds.SaveToFileTextData(matrix, debugDirectory);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            foreach (string line in File.ReadAllLines(path))
            {
                foreach (string value in line.Split(';'))
                {
                    Console.Write($"{value,5}");
                }

                Console.WriteLine();
            }

            Console.WriteLine("Файл сохранён по пути: " + path);
            Console.ReadLine();
        }
    }
}