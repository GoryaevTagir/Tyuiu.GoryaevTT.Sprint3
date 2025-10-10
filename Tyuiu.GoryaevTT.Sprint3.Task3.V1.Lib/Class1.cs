using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.GoryaevTT.Sprint3.Task3.V1.Lib
{
    public class Class1 : ISprint3Task3V1
    {
        public int GetCharCount(string value, char item)
        {
            int count = 0;
            foreach (char n in value)
            {
                if (n == item)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
