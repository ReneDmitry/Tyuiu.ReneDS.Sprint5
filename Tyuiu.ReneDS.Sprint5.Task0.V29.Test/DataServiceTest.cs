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
            int x = 3;

            string path = ds.SaveToFileTextData(x);
            string expectedPath = Path.Combine(
                @"C:\Users\Пользователь\source\repos\Tyuiu.ReneDS.Sprint5\Tyuiu.ReneDS.Sprint5.Task0.V29\bin\Debug",
                "OutPutFileTask0.txt");

            Assert.AreEqual(expectedPath, path);
            Assert.IsTrue(File.Exists(path));

            string wait = 169.890.ToString("F3");
            string res = File.ReadAllText(path);

            Assert.AreEqual(wait, res);
        }
    }
}
