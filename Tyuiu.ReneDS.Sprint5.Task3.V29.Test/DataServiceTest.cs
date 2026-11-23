using Tyuiu.ReneDS.Sprint5.Task3.V29.Lib;

namespace Tyuiu.ReneDS.Sprint5.Task3.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string path = ds.SaveToFileTextData(3);
            string expectedPath = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

            Assert.AreEqual(expectedPath, path);
            Assert.IsTrue(File.Exists(path));

            using (BinaryReader reader = new BinaryReader(File.OpenRead(path)))
            {
                Assert.AreEqual(64.0, reader.ReadDouble());
            }
        }
    }
}
