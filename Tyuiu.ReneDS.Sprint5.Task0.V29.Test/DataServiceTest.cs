using Tyuiu.ReneDS.Sprint5.Task0.V29.Lib;

namespace Tyuiu.ReneDS.Sprint5.Task0.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string path = ds.SaveToFileTextData(3);
            string expectedPath = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");

            Assert.AreEqual(expectedPath, path);
            Assert.IsTrue(File.Exists(path));
            Assert.AreEqual(169.890.ToString("F3"), File.ReadAllText(path));
        }
    }
}
