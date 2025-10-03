using Tyuiu.NeupokoevSV.Sprint2.Task2.V12.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());

        bool res = ds.CheckDotInShadedArea(x, y);
        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        if (res)
        {
            Console.WriteLine("Точка находится в заштрихованной области");
        }
        else
        {
            Console.WriteLine("Точка находится в заштрихованной области");
        }
    }
}