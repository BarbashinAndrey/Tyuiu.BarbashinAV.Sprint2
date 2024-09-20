using System.Drawing;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BarbashinAV.Sprint2.Task2.V10.Lib;

public class DataService : ISprint2Task2V10
{
    public bool CheckDotInShadedArea(int x, int y)
    {
        int[,] area = new int[,]
        {
            { 3, 3 }, { 3, 4 }, { 3, 5 }, { 3, 9 }, { 3, 10 }, { 3, 11 }, { 3, 12 },
            { 4, 3 }, { 4, 4 }, { 4, 5 }, { 4, 9 }, { 4, 10 }, { 4, 11 }, { 4, 12 },
            { 5, 3 }, { 5, 4 }, { 5, 5 }, { 5, 6 }, { 5, 7 }, { 5, 8 }, { 5, 9 }, { 5, 10 }, { 5, 11 }, { 5, 12 },
            { 6, 3 }, { 6, 4 }, { 6, 5 }, { 6, 6 }, { 6, 7 }, { 6, 8 }, { 6, 9 }, { 6, 10 }, { 6, 11 }, { 6, 12 }, { 6, 13 },
            { 7, 3 }, { 7, 4 }, { 7, 5 }, { 7, 6 }, { 7, 7 }, { 7, 8 }, { 7, 9 }, { 7, 10 }, { 7, 11 }, { 7, 12 }, { 7, 13 },
            { 8, 4 }, { 8, 6 }, { 8, 7 }, { 8, 8 }, { 8, 9 }, { 8, 10 }, { 8, 11 }, { 8, 12 }, { 8, 13 },
            { 9, 4 }, { 9, 6 }, { 9, 7 }, { 9, 8 }, { 9, 9 },
            { 10, 4 }, { 10, 8 }, { 10, 9 },
            { 11, 3 }, { 11, 4 }, { 11, 5 }, { 11, 8 }, { 11, 9 },
            { 12, 4 }, { 12, 8 }, { 12, 9 },
            { 13, 4 },
            { 14, 2 }, { 14, 3 }, { 14, 4 }, { 14, 5 }, { 14, 6 },
        };

        for (int i = 0; i < area.GetLength(0); i++)
            for (int j = 0; j < area.GetLength(1); j += 2)
                if (area[i, j] == x && area[i, j + 1] == y)
                    return true;
        return false;
    }
}
