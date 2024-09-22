using tyuiu.cources.programming.interfaces.Sprint2; 
 
namespace Tyuiu.BarbashinAV.Sprint2.Task5.V13.Lib;

public class DataService : ISprint2Task5V13
{
    public string FindDateOfNextDay(int g, int m, int n)
    {
        // ñàéò òğåáóåò îòâåòà â ôîğìàòå ää.ìì.ãããã
        // ïîıòîìó ÿ íå çíàş, ãäå òóò ìîæíî èñïîëüçîâàòü switch)))

        if (!(m >= 1 && m <= 12))
            throw new ArgumentException("Íåêîğğåêòíûé íîìåğ ìåñÿöà");

        int[] monthesDays = new int[] { 0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        if (n > monthesDays[m])
            throw new ArgumentException("Íåêîğğåêòíîå ÷èñëî");

        if (n + 1 > monthesDays[m])
        {
            m = m >= 12 ? 1 : m + 1;
            n = 1;
        }
        else
        {
            n++;
        }
        //string month = m switch
        //{
        //    1 => "ÿíâàğÿ",
        //    2 => "ôåâğàëÿ",
        //    3 => "ìàğòà",
        //    4 => "àïğåëÿ",
        //    5 => "ìàÿ",
        //    6 => "èşíÿ",
        //    7 => "èşëÿ",
        //    8 => "àâãóñòà",
        //    9 => "ñåíòÿáğÿ",
        //    10 => "îêòÿáğÿ",
        //    11 => "íîÿáğÿ",
        //    12 => "äåêàáğÿ",
        //    _ => ""
        //};
        return $"{n:D2}.{m:D2}.{g}";
    }
} 
