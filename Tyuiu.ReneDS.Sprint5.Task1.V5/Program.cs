using System;
using System.IO;
using Tyuiu.ReneDS.Sprint5.Task1.V5.Lib;

namespace Tyuiu.ReneDS.Sprint5.Task1.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Ренье Д. С. | АСОиУБ-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Работа с текстовыми файлами                                       *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Ренье Дмитрий Сергеевич | АСОиУБ-26-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Протабулировать F(x) = 5 - 3x + (1 + sin(x)) / (2x - 0.5)                 *");
            Console.WriteLine("* на отрезке [-5; 5] с шагом 1. При делении на ноль принять F(x) = 0.      *");
            Console.WriteLine("* Округлить значения до двух знаков, записать их в OutPutFileTask1.txt     *");
            Console.WriteLine("* и вывести таблицу на консоль.                                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Начало диапазона = " + startValue);
            Console.WriteLine("Конец диапазона  = " + stopValue);
            Console.WriteLine("Шаг              = 1");

            string path = ds.SaveToFileTextData(startValue, stopValue);
            string[] results = File.ReadAllLines(path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("+------+----------+");
            Console.WriteLine("|  x   |   F(x)   |");
            Console.WriteLine("+------+----------+");

            for (int i = 0; i < results.Length; i++)
            {
                int x = startValue + i;
                Console.WriteLine($"| {x,4} | {results[i],8} |");
            }

            Console.WriteLine("+------+----------+");

            if (OperatingSystem.IsWindows())
            {
                string debugDirectory = @"C:\Users\Пользователь\source\repos\Tyuiu.ReneDS.Sprint5\Tyuiu.ReneDS.Sprint5.Task1.V5\bin\Debug";
                Directory.CreateDirectory(debugDirectory);

                string debugPath = Path.Combine(debugDirectory, Path.GetFileName(path));
                File.Copy(path, debugPath, overwrite: true);

                Console.WriteLine("Копия файла сохранена: " + debugPath);
            }

            Console.ReadLine();
        }
    }
}