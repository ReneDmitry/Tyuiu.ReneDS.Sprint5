using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ReneDS.Sprint5.Task6.V19.Lib
{
    public class DataService : ISprint5Task6V19
    {
        public int LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);
            int res = Regex.Matches(text, @"(?<![0-9])[1-9][0-9](?![0-9])").Count;

            return res;
        }
    }
}
