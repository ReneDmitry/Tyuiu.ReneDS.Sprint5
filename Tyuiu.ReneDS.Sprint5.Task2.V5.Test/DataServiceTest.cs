using Tyuiu.ReneDS.Sprint5.Task2.V5.Lib;

namespace Tyuiu.ReneDS.Sprint5.Task2.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] matrix =
            {
                { 9, 6, 6 },
                { 8, 7, 2 },
                { 1, 7, 8 }
            };

            string path = ds.SaveToFileTextData(matrix);
            string expectedPath = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");
            string[] expectedLines = { "0;6;6", "8;0;2", "0;0;8" };

            Assert.AreEqual(expectedPath, path);
            Assert.IsTrue(File.Exists(path));
            CollectionAssert.AreEqual(expectedLines, File.ReadAllLines(path));
        }
    }
}
