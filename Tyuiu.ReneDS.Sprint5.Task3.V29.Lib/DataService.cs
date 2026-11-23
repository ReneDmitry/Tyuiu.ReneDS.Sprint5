using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ReneDS.Sprint5.Task3.V29.Lib
{
    public class DataService : ISprint5Task3V29
    {
        public string SaveToFileTextData(int x)
        {

            return SaveToDirectory(x, Path.GetTempPath());

        }
        public string SaveToDirectory(int x, string directory)
        {
            Directory.CreateDirectory(directory);
            string path = Path.Combine(directory, "OutPutFileTask3.bin");

            double res = Math.Pow(x, 3) + 2 * Math.Pow(x, 2) + 5.0 * x + 4;
            res = Math.Round(res, 3);

            using (BinaryWriter writer = new BinaryWriter(File.Create(path)))
            {
                writer.Write(res);
            }

            return path;

        }
    }
}
