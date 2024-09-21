using Tyuiu.BarbashinAV.Sprint2.Task3.V7.Lib;

namespace Tyuiu.BarbashinAV.Sprint2.Task3.V7;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Спринт #2 | Выполнил: Барбашин А. В. | ИИПб-24-1";
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* Спринт #2                                                            *");
        Console.WriteLine("* Тема: Логические операции                                            *");
        Console.WriteLine("* Задание #3                                                           *");
        Console.WriteLine("* Вариант #7                                                          *");
        Console.WriteLine("* Выполнил: Барбашин Андрей Владиславович | ИИПб-24-1                  *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                             *");
        Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y   *");
        Console.WriteLine("* с использованием вложенных оператор if-else, где пользователь вводит *");
        Console.WriteLine("* значение переменной X с клавиатуры. Округлить полученное значение до *");
        Console.WriteLine("* трех знаков после запятой;                                           *");
        Console.WriteLine("*                                                                      *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
        Console.WriteLine("************************************************************************");

        var x = double.Parse(Console.ReadLine()!);

        Console.WriteLine("************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
        Console.WriteLine("************************************************************************");

        Console.WriteLine($"Y = {new DataService().Calculate(x)}");
    }
}
