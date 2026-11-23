using Tyuiu.ReneDS.Sprint5.Task5.V26.Lib;

namespace Tyuiu.ReneDS.Sprint5.Task5.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = Path.GetTempFileName();

            try
            {
                File.WriteAllLines(path, new[] { "2,25", "-1,5", "3.1254", "-0.25", "0" });

                double res = ds.LoadFromDataFile(path);

                Assert.AreEqual(7.125, res, 0.000001);
            }
            finally
            {
                File.Delete(path);
            }
        }
    }
}
