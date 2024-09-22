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

        int next_m = m;
        if (n + 1 > monthesDays[m])
        {
            // сайт требует ответа в формате дд.мм.гггг
            // поэтому я не знаю, где тут можно использовать switch)))
            // можно, конечно, сделать определение следующего номера месяца
            // через switch, но это будет очень плохой код:
            switch(m)
            {
                case 1:
                    {
                        next_m = 2;
                        break;
                    }
                case 2:
                    {
                        next_m = 3;
                        break;
                    }
                case 3:
                    {
                        next_m = 4;
                        break;
                    }
                case 4:
                    {
                        next_m = 5;
                        break;
                    }
                case 5:
                    {
                        next_m = 6;
                        break;
                    }
                case 6:
                    {
                        next_m = 7;
                        break;
                    }
                case 7:
                    {
                        next_m = 8;
                        break;
                    }
                case 8:
                    {
                        next_m = 9;
                        break;
                    }
                case 9:
                    {
                        next_m = 10;
                        break;
                    }
                case 10:
                    {
                        next_m = 11;
                        break;
                    }
                case 11:
                    {
                        next_m = 12;
                        break;
                    }
                case 12:
                    {
                        next_m = 1;
                        break;
                    }
            }
            n = 1;
        }
        else
        {
            n++;
        }
        return $"{n:D2}.{next_m:D2}.{g}";
    }
} 
