using Tyuiu.GoryaevTT.Sprint3.Task1.V25.Lib;
namespace Tyuiu.GoryaevTT.Sprint3.Task1.V25
{
    class Program
    {
        public static void Main(string[] args)
        {
            Class1 ds = new Class1();
            int a = 1;
            int b = 6;
            int c = 2;
            double res = ds.GetMultiplySeries(c, a, b);
            Console.WriteLine(res);
        }

    }
}