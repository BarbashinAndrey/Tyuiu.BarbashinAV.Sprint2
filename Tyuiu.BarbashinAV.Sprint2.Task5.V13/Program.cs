using Tyuiu.BarbashinAV.Sprint2.Task5.V13.Lib;

namespace Tyuiu.BarbashinAV.Sprint2.Task5.V13;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Спринт #2 | Выполнил: Барбашин А. В. | ИИПб-24-1";
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* Спринт #2                                                            *");
        Console.WriteLine("* Тема: Оператор switch                                                *");
        Console.WriteLine("* Задание #5                                                           *");
        Console.WriteLine("* Вариант #13                                                          *");
        Console.WriteLine("* Выполнил: Барбашин Андрей Владиславович | ИИПб-24-1                  *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                             *");
        Console.WriteLine("* Дата некоторого дня характеризуется тремя натуральными числами:      *");
        Console.WriteLine("* g (год), m (порядковый номер месяца) и n (число). По заданным g, n   *");
        Console.WriteLine("* и m определить дату следующего дня. Заданный год является високосным *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
        Console.WriteLine("************************************************************************");

        Console.WriteLine("Введите год G:");
        int g = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Введите номер месяца M:");
        int m = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Введите число N:");
        int n = int.Parse(Console.ReadLine()!);

        Console.WriteLine("************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
        Console.WriteLine("************************************************************************");

        Console.WriteLine($"Следующий день = {new DataService().FindDateOfNextDay(g, m, n)}");
    }
}
