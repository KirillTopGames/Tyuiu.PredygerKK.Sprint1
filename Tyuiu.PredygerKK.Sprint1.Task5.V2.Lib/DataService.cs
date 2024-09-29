using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.PredygerKK.Sprint1.Task5.V2.Lib
{
    public class DataService : ISprint1Task5V2
    {
        public int FahrenheitToСelsius(double temp)
        {
            int res = Convert.ToInt32(5 / 9 * (temp - 32));
            return res;
        }
    }
}
