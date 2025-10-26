using Tyuiu.DolgovIV.Sprint3.Task5.V2.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Выполнил: Долгов И. В. | АСОиУб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Вложенные циклы                                                   *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #2                                                              *");
        Console.WriteLine("* Выполнил: Долгов Илья Витальевич | АСОиУб-25-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Решить уравнение                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int x = Convert.ToInt32(Console.ReadLine());

        int startValue1 = Convert.ToInt32(Console.ReadLine());
        int startValue2 = Convert.ToInt32(Console.ReadLine());

        int stopValue1 = Convert.ToInt32(Console.ReadLine());
        int stopValue2 = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2));

        Console.ReadKey();
    }
}