using Tyuiu.DolgovIV.Sprint3.Task5.V2.Lib;

namespace Tyuiu.DolgovIV.Sprint3.Task5.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 5;
            int z1 = 1;
            int z2 = 1;
            int y1 = 3;
            int y2 = 12;
            Assert.AreEqual(ds.GetSumSumSeries(x, z1, z2, y1, y2), 35.658);
        }
    }
}
