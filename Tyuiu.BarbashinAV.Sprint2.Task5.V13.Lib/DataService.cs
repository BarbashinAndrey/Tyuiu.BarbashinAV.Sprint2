using tyuiu.cources.programming.interfaces.Sprint2; 
 
namespace Tyuiu.BarbashinAV.Sprint2.Task5.V13.Lib;

public class DataService : ISprint2Task5V13
{
    public string FindDateOfNextDay(int g, int m, int n)
    {
        if (!(m >= 1 && m <= 12))
            throw new ArgumentException("������������ ����� ������");

        int[] monthesDays = new int[] { 0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        if (n > monthesDays[m])
            throw new ArgumentException("������������ �����");

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
            1 => "������",
            2 => "�������",
            3 => "�����",
            4 => "������",
            5 => "���",
            6 => "����",
            7 => "����",
            8 => "�������",
            9 => "��������",
            10 => "�������",
            11 => "������",
            12 => "�������",
            _ => ""
        };
        return $"{n} {month}, {g}";
    }
} 
