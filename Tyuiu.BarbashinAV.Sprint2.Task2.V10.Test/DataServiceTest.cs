using Tyuiu.BarbashinAV.Sprint2.Task2.V10.Lib;

namespace Tyuiu.BarbashinAV.Sprint2.Task2.V10.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidCheckDotInShadedArea()
    {
        Assert.AreEqual(true, new DataService().CheckDotInShadedArea(6, 8));
    }
}