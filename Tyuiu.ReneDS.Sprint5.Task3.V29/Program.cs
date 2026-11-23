using System;
using System.IO;
using Tyuiu.ReneDS.Sprint5.Task3.V29.Lib;

namespace Tyuiu.ReneDS.Sprint5.Task3.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Ренье Д. С. | АСОиУБ-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                                        *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил: Ренье Дмитрий Сергеевич | АСОиУБ-26-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить F(x) = x^3 + 2x^2 + 5x + 4 при x = 3.                        *");
            Console.WriteLine("* Округлить результат до трёх знаков, записать в OutPutFileTask3.bin        *");
            Console.WriteLine("* и вывести на консоль.                                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 3;
            Console.WriteLine("x = " + x);

            string debugDirectory =
                @"C:\Users\Пользователь\source\repos\Tyuiu.ReneDS.Sprint5\Tyuiu.ReneDS.Sprint5.Task3.V29\bin\Debug";

            string path = ds.SaveToDirectory(x, debugDirectory);

            double res;
            using (BinaryReader reader = new BinaryReader(File.OpenRead(path)))
            {
                res = reader.ReadDouble();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("F(x) = " + res);
            Console.WriteLine("Файл сохранён по пути: " + path);
            Console.ReadLine();
        }
    }
}
