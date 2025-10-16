using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.GoryaevTT.Sprint3.Task5.V18.Lib
{
    public class Class1 : ISprint3Task5V18
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double res = 0;
            for (int i = startValue1; i <= stopValue1; i++)
            {
                for (int j = startValue2; j <= stopValue2; j++)
                {
                    res += Math.Cos(x) + Math.Pow(j, 2) / 2;
                }
            }
            return Math.Round(res, 2);
        }
    }
}
