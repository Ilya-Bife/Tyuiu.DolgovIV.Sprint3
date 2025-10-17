using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.DolgovIV.Sprint3.Task0.V4.Lib
{
    public class DataService : ISprint3Task0V4
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double res = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                res += Math.Sin(0.1) + i;
            }
            return Math.Round(res, 3);
        }
    }
}

