using Tyuiu.PredygerKK.Sprint1.Task6.V10.Lib;

namespace Tyuiu.PredygerKK.Sprint1.Task6.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            DataService ds = new DataService();

            string value;

            value = "Kirill Dimon Maks Vovan Baha Danya Semen";
            value = ds.DeleteMiddleLetter(value);
            Assert.AreEqual("Kirill Dion Maks Voan Baha Daya Seen", ds.DeleteMiddleLetter(value));
        }
    }
}