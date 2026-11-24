using Tyuiu.ReneDS.Sprint5.Task6.V19.Lib;

namespace Tyuiu.ReneDS.Sprint5.Task6.V19.Test
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
                File.WriteAllText(path, "a12b 7 -34 105 09 99");

                int res = ds.LoadFromDataFile(path);

                Assert.AreEqual(3, res);
            }
            finally
            {
                File.Delete(path);
            }

        }


    }
}
