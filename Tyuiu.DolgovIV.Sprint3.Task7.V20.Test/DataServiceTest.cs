using Tyuiu.DolgovIV.Sprint3.Task7.V20.Lib;

namespace Tyuiu.DolgovIV.Sprint3.Task7.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = -5;
            int y = 5;
            double[] res = { 17.27, 14.08, 10.27, 6.65, 3.87, 2, -0.74, -3.71, -7.59, -11.55, -14.74 };
            

            CollectionAssert.AreEqual(ds.GetMassFunction(x,y), res);
        }
    }
}












