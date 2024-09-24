using Tyuiu.PredygerKK.Sprint1.Task3.V17.Lib;

namespace Tyuiu.PredygerKK.Sprint1.Task3.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            DataService ds = new DataService();
            double number = 0.0005666;
            int r = (int)(number * 1000);
            if (r % 10 == 0 || r % 100 == 0 || r % 1000 == 0)
            {
                Console.WriteLine("YES");
            }
            else 
            {
                Console.WriteLine("NO");
            }
        }
    }
}