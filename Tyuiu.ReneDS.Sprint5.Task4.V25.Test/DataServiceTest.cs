using Tyuiu.ReneDS.Sprint5.Task4.V25.Lib;

namespace Tyuiu.ReneDS.Sprint5.Task4.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.GetTempFileName();

            try
            {
                File.WriteAllText(path, "1");

                FileInfo fileInfo = new FileInfo(path);
                bool fileExists = fileInfo.Exists;
                bool wait = true;

                Assert.AreEqual(wait, fileExists);

                DataService ds = new DataService();
                double res = ds.LoadFromDataFile(path);
                Assert.AreEqual(1.296, res, 0.000001);
            }
            finally
            {
                File.Delete(path);
            }
        }
    }
}
