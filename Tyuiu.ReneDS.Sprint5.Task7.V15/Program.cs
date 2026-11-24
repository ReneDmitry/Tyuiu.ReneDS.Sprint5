using System;
using System.IO;
using Tyuiu.ReneDS.Sprint5.Task7.V15.Lib;

namespace Tyuiu.ReneDS.Sprint5.Task7.V15
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
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Ренье Дмитрий Сергеевич | АСОиУБ-26-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Удалить из файла все слова длиной два символа.                          *");
            Console.WriteLine("* Сохранить результат в OutPutDataFileTask7V15.txt.                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = Path.Combine(@"C:\DataSprint5", "InPutDataFileTask7V15.txt");
            Console.WriteLine("Данные находятся в файле: " + path);

            if (!File.Exists(path))
            {
                Console.WriteLine("Файл не найден. Скопируй файл варианта 15 по указанному пути.");
                Console.ReadKey();
                return;
            }

            string debugDirectory =
                @"C:\Users\Пользователь\source\repos\Tyuiu.ReneDS.Sprint5\Tyuiu.ReneDS.Sprint5.Task7.V15\bin\Debug";

            string outputPath = ds.SaveToDirectory(path, debugDirectory);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(File.ReadAllText(outputPath));
            Console.WriteLine("Файл сохранён по пути: " + outputPath);

            Console.ReadKey();
        }
    }
}