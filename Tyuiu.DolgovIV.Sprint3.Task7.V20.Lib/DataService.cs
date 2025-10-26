using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.DolgovIV.Sprint3.Task7.V20.Lib
{
    public class DataService : ISprint3Task7V20
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] res = {0,0,0,0,0,0,0,0,0,0,0};
            int i = 0;
            for (startValue = -5; startValue <= stopValue; startValue++)
            {
                if (3 * startValue - 1 == 0)
                {
                    res[i] = 0;
                    i++;
                    continue;
                }

                double fx = (Math.Sin(startValue) - 2 * startValue) / (3 * startValue - 1) + Math.Sin(startValue) - 3 * startValue + 2;

                res[i] = Math.Round(fx, 2);
                i++;

            }
            return res;
        }
    }
}
