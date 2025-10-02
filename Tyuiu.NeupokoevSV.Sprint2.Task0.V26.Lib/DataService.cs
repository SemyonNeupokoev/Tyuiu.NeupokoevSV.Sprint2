using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.NeupokoevSV.Sprint2.Task0.V26.Lib
{
    public class DataService : ISprint2Task0V26
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];
            res[0] = x == y;
            res[1] = (y + 70) != x;
            res[2] = x < y;
            res[3] = x  > y;
            res[4] = (x - 100) <= y;
            res[5] = x >= y;
            return res;
        }
    }
}
