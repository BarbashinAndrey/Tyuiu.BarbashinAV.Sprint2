using Tyuiu.BarbashinAV.Sprint2.Task2.V10.Lib;

namespace Tyuiu.BarbashinAV.Sprint2.Task2.V10;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Спринт #2 | Выполнил: Барбашин А. В. | ИИПб-24-1";
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* Спринт #2                                                            *");
        Console.WriteLine("* Тема: Оператор if – полная и короткая форма записи                   *");
        Console.WriteLine("* Задание #2                                                           *");
        Console.WriteLine("* Вариант #10                                                          *");
        Console.WriteLine("* Выполнил: Барбашин Андрей Владиславович | ИИПб-24-1                  *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                             *");
        Console.WriteLine("* Написать программу на, которая запрашивает целые значения            *");
        Console.WriteLine("* с клавиатуры и вычисляет находится ли точка с координатами X,Y в     *");
        Console.WriteLine("* в заштрихованной области.                                            *");
        Console.WriteLine("*                                                                      *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
        Console.WriteLine("************************************************************************");

        Console.WriteLine("Введите координату X:");
        int x = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Введите координату Y:");
        int y = int.Parse(Console.ReadLine()!);

        Console.WriteLine("************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
        Console.WriteLine("************************************************************************");

        var result = new DataService().CheckDotInShadedArea(x, y);
        Console.WriteLine(
            result 
            ? "Точка находится в заштрихованной области"
            : "Точка не находится в заштрихованной области"
        );
        Console.WriteLine();
    }
}
