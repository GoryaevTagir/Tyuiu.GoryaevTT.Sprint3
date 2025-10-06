using Tyuiu.GoryaevTT.Sprint3.Task0.V29.Lib;
namespace Tyuiu.GoryaevTT.Sprint3.Task0.V29
{
    class Program
    {
        public static void Main(string[] args)
        {
            Class1 ds = new Class1();
            double value = 0.5;
            int startValue = 1;
            int stopValue = 10;
            double res = ds.GetSumSeries(value, startValue, stopValue);
            Console.WriteLine(res);
        }
    }
}