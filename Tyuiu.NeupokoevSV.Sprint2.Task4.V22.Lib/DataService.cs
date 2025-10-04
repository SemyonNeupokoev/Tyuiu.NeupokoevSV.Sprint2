using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.NeupokoevSV.Sprint2.Task4.V22.Lib
{
    public class DataService : ISprint2Task4V22
    {
        public double Calculate(double x, double y)
        {
            double z = 0;
            if ((x - 3) > y * 2 - 21)
            {
                z = Math.Pow(x, 2) + 12 * y - (2 / x);
            }
            else
            {
                z = ((Math.Pow(x, 2) + Math.Cos(Math.Pow(y, 2) + 17)) / Math.Pow(y, 2) - Math.Sin(Math.Pow(y, 2) + 3));
            }
            return z;
        }
    }
}
