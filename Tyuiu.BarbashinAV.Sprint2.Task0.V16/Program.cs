using Tyuiu.BarbashinAV.Sprint2.Task0.V16.Lib;

namespace Tyuiu.BarbashinAV.Sprint2.Task0.V16;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Спринт #2 | Выполнил: Барбашин А. В. | ИИПб-24-1";
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* Спринт #2                                                            *");
        Console.WriteLine("* Тема: Операции сравнения                                             *");
        Console.WriteLine("* Задание #0                                                           *");
        Console.WriteLine("* Вариант #16                                                          *");
        Console.WriteLine("* Выполнил: Барбашин Андрей Владиславович | ИИПб-24-1                  *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                             *");
        Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,      *");
        Console.WriteLine("* последовательность операций не должна нарушаться) и арифметических   *");
        Console.WriteLine("* выражений которая вернет логическую последовательность(массив):      *");
        Console.WriteLine("* (True, False, True, False, True, False), при x = 1025, y = 275       *");
        Console.WriteLine("*                                                                      *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* X = 1025                                                             *");
        Console.WriteLine("* Y = 275                                                              *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
        Console.WriteLine("************************************************************************");
        int x = 1025;
        int y = 275;
        Console.WriteLine(string.Join("\n", new DataService().GetCompareOperations(x, y)));
        Console.ReadKey();
    }
}
