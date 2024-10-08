﻿using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BarbashinAV.Sprint2.Task0.V16.Lib;

public class DataService : ISprint2Task0V16
{
    public bool[] GetCompareOperations(int x, int y)
        => new bool[] {
            x == y + 750, x != y + 750, x - 751 < y, x > y + 751,
            x - 750 <= y, x >= y + 751
        };
}
