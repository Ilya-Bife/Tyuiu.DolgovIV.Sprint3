using Tyuiu.DolgovIV.Sprint3.Task3.V10.Lib;

namespace Tyuiu.DolgovIV.Sprint3.Task3.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            string str = "gdfppf vfppt p";

            char val = 'p';

            Assert.AreEqual(ds.DeleteCharInString(str, val), "gdf  f vf  t  ");

        }
    }
}
