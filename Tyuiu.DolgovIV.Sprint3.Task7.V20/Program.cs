using Tyuiu.DolgovIV.Sprint3.Task7.V20.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");


        Console.WriteLine("+----------+----------+");
        Console.WriteLine("+    X     +    f(x)  +");
        Console.WriteLine("+----------+----------+");
        for (int i = 0; i < ds.GetMassFunction(x, y).Length; i++)
        {
            Console.WriteLine("|   " + ds.GetMassFunction(x, y)[i] + "   |" + "   " + Convert.ToString(i - 5) + "   |"); 
        }
        Console.WriteLine("+----------+----------+");


        Console.ReadKey();


    }
}