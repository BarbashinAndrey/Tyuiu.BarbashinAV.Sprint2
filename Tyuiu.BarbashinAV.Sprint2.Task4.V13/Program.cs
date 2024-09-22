using Tyuiu.BarbashinAV.Sprint2.Task4.V13.Lib;

namespace Tyuiu.BarbashinAV.Sprint2.Task4.V13;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Спринт #2 | Выполнил: Барбашин А. В. | ИИПб-24-1";
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* Спринт #2                                                            *");
        Console.WriteLine("* Тема: Тернарный оператор                                             *");
        Console.WriteLine("* Задание #4                                                           *");
        Console.WriteLine("* Вариант #13                                                          *");
        Console.WriteLine("* Выполнил: Барбашин Андрей Владиславович | ИИПб-24-1                  *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                             *");
        Console.WriteLine("* Написать программу, которая вычисляет требуемое значение с           *");
        Console.WriteLine("* использованием тернарного оператора, где пользователь вводит         *");
        Console.WriteLine("* значение переменных x, y с клавиатуры                                *");
        Console.WriteLine("* если Math.Sqrt(x) * 3 > y * 2 - 20, то z = x + 10 * y - (1 / x)      *");
        Console.WriteLine("* иначе (x * x + Math.Cos(y * y) + 13) / (y * y - Math.Sin(y * y) + 9) *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
        Console.WriteLine("************************************************************************");

        Console.WriteLine("Введите переменную X:");
        int x = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Введите переменную Y:");
        int y = int.Parse(Console.ReadLine()!);

        Console.WriteLine("************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
        Console.WriteLine("************************************************************************");

        Console.WriteLine($"Ответ = {new DataService().Calculate(x, y)}");
    }
}
