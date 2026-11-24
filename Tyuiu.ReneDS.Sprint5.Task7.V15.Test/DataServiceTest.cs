using Tyuiu.ReneDS.Sprint5.Task7.V15.Lib;

namespace Tyuiu.ReneDS.Sprint5.Task7.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string directory = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            Directory.CreateDirectory(directory);

            try
            {
                string inputPath = Path.Combine(directory, "InPutDataFileTask7V15.txt");
                File.WriteAllText(inputPath, "Это is just a sample строки in English.");

                string outputPath = ds.SaveToDirectory(inputPath, directory);

                Assert.AreEqual(
                    Path.Combine(directory, "OutPutDataFileTask7V15.txt"),
                    outputPath);
                Assert.AreEqual(
                    "Это just a sample строки English.",
                    File.ReadAllText(outputPath));
            }
            finally
            {
                Directory.Delete(directory, recursive: true);
            }
        }
    }
}
