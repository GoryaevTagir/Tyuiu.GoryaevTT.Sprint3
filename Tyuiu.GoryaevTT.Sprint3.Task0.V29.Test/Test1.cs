using Newtonsoft.Json.Linq;
using Tyuiu.GoryaevTT.Sprint3.Task0.V29.Lib;
namespace Tyuiu.GoryaevTT.Sprint3.Task0.V29.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 ds = new Class1();
            double value = 0.5;
            int startValue = 1;
            int stopValue = 10;
            double res = ds.GetSumSeries(value, startValue, stopValue);
            Assert.AreEqual(2.194, res);
        }
    }
}
