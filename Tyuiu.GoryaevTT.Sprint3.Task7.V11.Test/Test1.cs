using Tyuiu.GoryaevTT.Sprint3.Task7.V11.Lib;
namespace Tyuiu.GoryaevTT.Sprint3.Task7.V11.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 ds =new Class1();
            double[] res = ds.GetMassFunction(-5, 5);
            int len = 5 + 5 + 1;
            double[] wait = new double[len] {};
            CollectionAssert.AreEqual(res, wait);
        }
    }
}
