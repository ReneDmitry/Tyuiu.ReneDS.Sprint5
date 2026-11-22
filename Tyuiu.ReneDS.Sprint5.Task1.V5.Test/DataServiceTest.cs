using Tyuiu.ReneDS.Sprint5.Task1.V5.Lib;

namespace Tyuiu.ReneDS.Sprint5.Task1.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string path = ds.SaveToFileTextData(-5, 5);
            string expectedPath = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            Assert.AreEqual(expectedPath, path);
            Assert.IsTrue(File.Exists(path));

            double[] expectedValues =
            {
                19.81, 16.79, 13.87, 10.98, 7.94, 3,
                3.23, -0.45, -3.79, -6.97, -10
            };

            string[] expectedLines = Array.ConvertAll(
                expectedValues, value => value.ToString());

            CollectionAssert.AreEqual(expectedLines, File.ReadAllLines(path));
        }
    }
}
