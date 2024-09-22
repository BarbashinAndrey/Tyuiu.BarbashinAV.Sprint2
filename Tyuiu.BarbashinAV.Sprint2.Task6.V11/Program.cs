using Tyuiu.BarbashinAV.Sprint2.Task6.V11.Lib; 
 
namespace Tyuiu.BarbashinAV.Sprint2.Task6.V11; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        Console.Title = "Спринт #2 | Выполнил: Барбашин А.В. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #2                                                            *"); 
        Console.WriteLine("* Тема:                                                                *"); 
        Console.WriteLine("* Задание #6                                                           *"); 
        Console.WriteLine("* Вариант #11                                                          *"); 
        Console.WriteLine("* Выполнил: Барбашин Андрей Владиславович                              *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ:                                                             *");
        Console.WriteLine("* Дата некоторого дня характеризуется тремя натуральными числами:      *");
        Console.WriteLine("* g (год),m (порядковый номер месяца) и n (число). По заданным g,n и m *");
        Console.WriteLine("* определить дату следующего дня. Заданный год не является високосным  *");
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
