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
            double[] wait = new double[] { 20.36, 15.42, 10.99, 7.43, 4.33, 1.0, 0.0, -8.87, -13.03, -16.53, -19.6};
            CollectionAssert.AreEqual(res, wait);
        }
    }
}
