using Tyuiu.BarbashinAV.Sprint2.Task3.V7.Lib;

namespace Tyuiu.BarbashinAV.Sprint2.Task3.V7.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidCondition1()
    {
        double x = 2;
        Assert.AreEqual(50, new DataService().Calculate(x));
    }

    [TestMethod]
    public void ValidCondition2()
    {
        double x = 0;
        Assert.AreEqual(0.75, new DataService().Calculate(x));
    }

    [TestMethod]
    public void ValidCondition3()
    {
        double x = -5;
        Assert.AreEqual(49.562, new DataService().Calculate(x));
    }

    [TestMethod]
    public void ValidCondition4()
    {
        double x = -12;
        Assert.AreEqual(20736.25, new DataService().Calculate(x));
    }
}