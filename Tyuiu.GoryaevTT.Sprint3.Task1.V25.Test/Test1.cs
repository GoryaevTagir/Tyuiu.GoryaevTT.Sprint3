using Tyuiu.GoryaevTT.Sprint3.Task1.V25.Lib;
namespace Tyuiu.GoryaevTT.Sprint3.Task1.V25.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 ds = new Class1();
            int a = 1;
            int b = 6;
            int c = 2;
            double res = ds.GetMultiplySeries(c, a, b);
            Assert.AreEqual(844.664, res);
        }
    }
}
