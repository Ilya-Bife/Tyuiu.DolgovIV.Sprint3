using Tyuiu.DolgovIV.Sprint3.Task1.V6.Lib;

namespace Tyuiu.DolgovIV.Sprint3.Task1.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 4;
            int value = 4;

            Assert.AreEqual(ds.GetSumSeries(value, startValue, stopValue), -165.66);

        }
    }
}
