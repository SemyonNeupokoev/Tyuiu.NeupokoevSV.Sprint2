using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.NeupokoevSV.Sprint2.Task7.V4.Lib
{
    public class DataService : ISprint2Task7V4
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if ((x >= -1 && x <= 1) && (y >= 0 && y <= 1))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
