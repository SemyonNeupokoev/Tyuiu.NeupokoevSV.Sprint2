using Tyuiu.NeupokoevSV.Sprint2.Task1.V22.Lib;
using Tyuiu.NeupokoevSV.Sprint2.Task1.V22;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int a = 324;
        int b = 696;
        int c = 254;
        int d = 155;
        bool[] res = new bool[6];
        res = ds.GetLogicOperations(a, b, c, d);
        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(res[i]);
        }
    }
}