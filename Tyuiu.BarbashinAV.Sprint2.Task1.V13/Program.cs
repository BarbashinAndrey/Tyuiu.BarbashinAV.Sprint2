using Tyuiu.BarbashinAV.Sprint2.Task1.V13.Lib;

namespace Tyuiu.BarbashinAV.Sprint2.Task1.V13;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Спринт #2 | Выполнил: Барбашин А. В. | ИИПб-24-1";
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* Спринт #2                                                            *");
        Console.WriteLine("* Тема: Логические операции                                            *");
        Console.WriteLine("* Задание #1                                                           *");
        Console.WriteLine("* Вариант #13                                                          *");
        Console.WriteLine("* Выполнил: Барбашин Андрей Владиславович | ИИПб-24-1                  *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                             *");
        Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,      *");
        Console.WriteLine("* в выражении) и логических операций (|, &, ||, &&, !, ^,              *");
        Console.WriteLine("* последовательность операций не должна нарушаться), а также           *");
        Console.WriteLine("* арифметических выражений, которая вернет логическую                  *");
        Console.WriteLine("* последовательность(массив): (True, True, True, True, True, False),   *");
        Console.WriteLine("* при a = 145, b = 916, c = 164, d = 137                               *");
        Console.WriteLine("*                                                                      *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* a = 145                                                              *");
        Console.WriteLine("* b = 916                                                              *");
        Console.WriteLine("* c = 164                                                              *");
        Console.WriteLine("* d = 137                                                              *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
        Console.WriteLine("************************************************************************");
        int a = 145, b = 916, c = 164, d = 137;
        Console.WriteLine(string.Join("\n", new DataService().GetLogicOperations(a, b, c, d)));
        Console.ReadKey();
    }
}
