using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.PredygerKK.Sprint1.Task3.V17.Lib
{
    public class DataService : ISprint1Task3V17
    {
        public bool ZeroCheck(double number)
        {
            int r = (int)(number * 1000);
            if (r % 10 == 0 || r % 100 == 0 || r % 1000 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

