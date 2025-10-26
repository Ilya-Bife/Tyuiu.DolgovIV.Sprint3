using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.DolgovIV.Sprint3.Task6.V7.Lib
{
    public class DataService : ISprint3Task6V7
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int res = 0;
            for (startValue = 17; startValue <= stopValue; startValue++)
            {
                for (int i = 1; i <= startValue; i++)
                {
                    if (startValue % i == 0)
                    {
                        res += i;    
                    }
                }
            }
            return res;
        }
    }
}
