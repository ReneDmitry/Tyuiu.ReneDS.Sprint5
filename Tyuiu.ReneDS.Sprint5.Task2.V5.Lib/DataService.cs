using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ReneDS.Sprint5.Task2.V5.Lib
{
    public class DataService : ISprint5Task2V5
    {
        public string SaveToFileTextData(int[,] matrix)
        { 
            return SaveToFileTextData(matrix, Path.GetTempPath());
        }
        

        public string SaveToFileTextData(int[,] matrix, string directory)
        {
            Directory.CreateDirectory(directory);
            string path = Path.Combine(directory, "OutPutFileTask2.csv");

            string[] lines = new string[matrix.GetLength(0)];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] values = new string[matrix.GetLength(1)];

                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    int value = matrix[row, column];

                    if (value % 2 != 0)
                    {
                        value = 0;
                    }

                    values[column] = value.ToString();
                }

                lines[row] = string.Join(";", values);
            }

            File.WriteAllLines(path, lines);
            return path;
        }

    }
}
