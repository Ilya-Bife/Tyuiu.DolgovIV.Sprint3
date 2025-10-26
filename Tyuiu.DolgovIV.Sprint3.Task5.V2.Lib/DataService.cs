using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.DolgovIV.Sprint3.Task5.V2.Lib
{
    public class DataService : ISprint3Task5V2
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double res = 0;
            for (startValue1 = 1; startValue1 <= stopValue1; startValue1++)
            {
                for (startValue2 = 1; startValue2 <= stopValue2; startValue2++)
                {
                    res += (Math.Cos(startValue2) + x) / x;
                }
            }
            return Math.Round(res,3);
        }
    }
}
