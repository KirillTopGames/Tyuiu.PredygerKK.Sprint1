using Tyuiu.PredygerKK.Sprint1.Task7.V30.Lib;

namespace Tyuiu.PredygerKK.Sprint1.Task7.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            DataService ds = new DataService();
            double x = 3.14;
            double y = 78.456;
            double res = 27.212;
            Assert.AreEqual(res, ds.Calculate(x, y));
        }
    }
}