using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.GoryaevTT.Sprint3.Task7.V11.Lib
{
    public class Class1 : ISprint3Task7V11
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] res;
            int len = stopValue - startValue + 1;
            res = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 1)
                {
                    res[count] = 0;
                    count++;
                }
                 else {
                    y = Math.Cos(x) + Math.Sin(x) / (2 - 2 * x) - 4 * x;
                    res[count] = Math.Round(y, 2);
                    count++;
                }
            }
            return res;
        }   
    }
}
