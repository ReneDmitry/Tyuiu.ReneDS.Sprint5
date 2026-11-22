using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ReneDS.Sprint5.Task1.V5.Lib
{
    public class DataService : ISprint5Task1V5
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            using (StreamWriter writer = new StreamWriter(path))
            {
                for (int x = startValue; x <= stopValue; x++)
                {
                    double denominator = 2.0 * x - 0.5;
                    double res = 0;

                    if (denominator != 0)
                    {
                        res = 5 - 3.0 * x + (1 + Math.Sin(x)) / denominator;
                    }

                    res = Math.Round(res, 2);
                    writer.WriteLine(res.ToString());
                }
            }

            return path;
        }
    }
}
