using Tyuiu.DolgovIV.Sprint3.Task2.V22.Lib;

namespace Tyuiu.DolgovIV.Sprint3.Task2.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            int value = 5;
            int startValue = 1;
            int stopValue = 5;

            Assert.AreEqual(ds.GetMultiplySeries(value, startValue, stopValue), 2.72);
        }
    }
}
