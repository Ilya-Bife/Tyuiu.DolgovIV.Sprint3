using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.DolgovIV.Sprint3.Task3.V10.Lib
{
    public class DataService : ISprint3Task3V10
    {
        public string DeleteCharInString(string value, char item)
        {
            string res = "";
            foreach (var item1 in value)
            {
                if (item1 != item)
                {
                    res += item1;
                }
            }
            return res;
        }
    }
}
