using tyuiu.cources.programming.interfaces.Sprint2; 
 
namespace Tyuiu.BarbashinAV.Sprint2.Task6.V11.Lib;

public class DataService : ISprint2Task6V11
{
    public string FindDateOfNextDay(int g, int m, int n)
    {
        if (!(m >= 1 && m <= 12))
            throw new ArgumentException("Некорректный номер месяца");

        int[] monthesDays = new int[] { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        if (n > monthesDays[m])
            throw new ArgumentException("Некорректное число");

        int next_m = m;
        if (n + 1 > monthesDays[m])
        {
            // сайт требует ответа в формате дд.мм.гггг
            // поэтому я не знаю, где тут можно использовать switch)))
            // можно, конечно, сделать определение следующего номера месяца
            // через switch, но это будет очень плохой код:
            next_m = m switch
            {
                1 => 2,
                2 => 3,
                3 => 4,
                4 => 5,
                5 => 6,
                6 => 7,
                7 => 8,
                8 => 9,
                9 => 10,
                10 => 11,
                11 => 12,
                12 => 1,
                _ => -1
            };
            n = 1;
        }
        else
        {
            n++;
        }
        return $"{n:D2}.{next_m:D2}.{g}";
    }
} 
