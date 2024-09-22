using tyuiu.cources.programming.interfaces.Sprint2; 
 
namespace Tyuiu.BarbashinAV.Sprint2.Task5.V13.Lib;

public class DataService : ISprint2Task5V13
{
    public string FindDateOfNextDay(int g, int m, int n)
    {
        if (!(m >= 1 && m <= 12))
            throw new ArgumentException("Некорректный номер месяца");

        int[] monthesDays = new int[] { 0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        if (n > monthesDays[m])
            throw new ArgumentException("Некорректное число");

        if (n + 1 > monthesDays[m])
        {
            m = m >= 12 ? 1 : m + 1;
            n = 1;
        }
        else
        {
            n++;
        }

        string month = m switch
        {
            1 => "января",
            2 => "февраля",
            3 => "марта",
            4 => "апреля",
            5 => "мая",
            6 => "июня",
            7 => "июля",
            8 => "августа",
            9 => "сентября",
            10 => "октября",
            11 => "ноября",
            12 => "декабря",
            _ => ""
        };
        return $"{n} {month}, {g}";
    }
} 
