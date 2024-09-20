using Tyuiu.BarbashinAV.Sprint2.Task1.V13.Lib;

namespace Tyuiu.BarbashinAV.Sprint2.Task1.V13.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidExpression()
    {
        var bool_coll = new bool[] { true, true, true, true, true, false };
        CollectionAssert.AreEqual(bool_coll, new DataService().GetLogicOperations(145, 916, 164, 137));
    }
}