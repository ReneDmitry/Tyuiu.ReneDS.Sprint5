using System;
using System.IO;
using Tyuiu.ReneDS.Sprint5.Task0.V29.Lib;

namespace Tyuiu.ReneDS.Sprint5.Task0.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Ренье Д. С. | АСОиУБ-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Запись данных в текстовый файл                                       *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил: Ренье Дмитрий Сергеевич | АСОиУБ-26-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить F(x) = 6.1x^3 + 0.23x^2 + 1.04x при x = 3.                     *");
            Console.WriteLine("* Округлить результат до трёх знаков после запятой, записать его в         *");
            Console.WriteLine("* OutPutFileTask0.txt и вывести на консоль.                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 3;
            Console.WriteLine("x = " + x);

            string path = ds.SaveToFileTextData(x);
            string res = File.ReadAllText(path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("F(x) = " + res);
            Console.WriteLine("Файл сохранён по пути: " + path);

            Console.ReadLine();
        }
    }
}
