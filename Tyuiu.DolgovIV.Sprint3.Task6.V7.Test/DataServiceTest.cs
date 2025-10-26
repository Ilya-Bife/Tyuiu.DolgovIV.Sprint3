using Tyuiu.DolgovIV.Sprint3.Task6.V7.Lib;


namespace Tyuiu.DolgovIV.Sprint3.Task6.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int start = 17;
            int end = 26;

            Assert.AreEqual(ds.GetSumTheDivisors(start,end), 344);
        }
    }
}
