using System.Diagnostics;
using tyuiu.cources.programming.interfaces.Sprint2; 
 
namespace Tyuiu.BarbashinAV.Sprint2.Task7.V6.Lib;

public class DataService : ISprint2Task7V6
{
    public bool CheckDotInShadedArea(double x, double y)
    {
        if (y < 0 || y > 2 || x < -2 || x > 2)
            return false;
        double res = x * x + y * y;
        if (res >= 1 && res <= 4)
            return true;
        return false;

    }
} 
