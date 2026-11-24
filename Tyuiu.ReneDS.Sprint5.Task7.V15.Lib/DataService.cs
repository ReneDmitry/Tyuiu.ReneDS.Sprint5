using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ReneDS.Sprint5.Task7.V15.Lib
{
    public class DataService : ISprint5Task7V15
    {
        public string LoadDataAndSave(string path)
        {
            return SaveToDirectory(path, Path.GetTempPath());
        }

        public string SaveToDirectory(string inputPath, string directory)
        {
            string[] lines = File.ReadAllLines(inputPath);

            for (int i = 0; i < lines.Length; i++)
            {
                string[] words = lines[i].Split(
                    new[] { ' ', '\t' },
                    StringSplitOptions.RemoveEmptyEntries);

                List<string> remainingWords = new List<string>();

                foreach (string word in words)
                {
                    if (word.Length != 2)
                    {
                        remainingWords.Add(word);
                    }
                }

                lines[i] = string.Join(" ", remainingWords);
            }

            Directory.CreateDirectory(directory);
            string outputPath = Path.Combine(directory, "OutPutDataFileTask7V15.txt");

            File.WriteAllText(outputPath, string.Join(Environment.NewLine, lines));

            return outputPath;
        }
    }
}
