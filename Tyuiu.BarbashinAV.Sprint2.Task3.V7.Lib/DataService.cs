using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BarbashinAV.Sprint2.Task3.V7.Lib;

public class DataService : ISprint2Task3V7
{
    public double Calculate(double x)
    {
        double res = 0.0;
        if (x > 1)
            res = x * Math.Pow(((x * x + 1) / (x - 1)), x);
        else if (x == 0)
            res = (x * x - Math.Cos(x * x) + 10)
                    / (x * x - Math.Sin(x * x) + 12);
        else if (-11 < x && x < 2)
            res = Math.Pow(7 + 1 / (x * x), 2);
        else if (x < -11)
            res = Math.Pow(x, 4) - (3 / x);
        return Math.Round(res, 3);
    }
}
