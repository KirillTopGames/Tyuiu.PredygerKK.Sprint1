using Tyuiu.PredygerKK.Sprint1.Task5.V2.Lib;

namespace Tyuiu.PredygerKK.Sprint1.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            DataService ds = new DataService();
            double temp = 367;
            Assert.AreEqual(186, ds.FahrenheitTo—elsius(temp));
        }
    }
}