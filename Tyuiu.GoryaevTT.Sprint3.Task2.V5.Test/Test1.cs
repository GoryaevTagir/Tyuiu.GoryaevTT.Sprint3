using Tyuiu.GoryaevTT.Sprint3.Task2.V5.Lib;
namespace Tyuiu.GoryaevTT.Sprint3.Task2.V5.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 ds = new Class1();
            double a = 0.75;
            int b = 1;
            int c = 20;
            double res = ds.GetSumSeries(a, b, c);
            Assert.AreEqual(-0.076, res);
        }
    }
}
