using Tyuiu.DolgovIV.Sprint3.Task0.V4.Lib;

namespace Tyuiu.DolgovIV.Sprint3.Task0.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 7;

            Assert.AreEqual(6482.439, ds.GetMultiplySeries(startValue, stopValue));
        }
    }
}
