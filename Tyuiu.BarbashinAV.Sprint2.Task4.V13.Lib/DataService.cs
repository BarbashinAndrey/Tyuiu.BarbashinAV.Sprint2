using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BarbashinAV.Sprint2.Task4.V13.Lib;

public class DataService : ISprint2Task4V13
{
    public double Calculate(double x, double y)
        => Math.Round(
            Math.Sqrt(x) * 3 > y * 2 - 20
            ? x + 10 * y - (1 / x)
            : (x * x + Math.Cos(y * y) + 13)
                / (y * y - Math.Sin(y * y) + 9),
           3);
}
