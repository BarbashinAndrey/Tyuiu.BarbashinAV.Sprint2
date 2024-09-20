using Tyuiu.BarbashinAV.Sprint2.Task0.V16.Lib;

namespace Tyuiu.BarbashinAV.Sprint2.Task0.V16.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidExpression()
    {
        var bool_coll = new bool[] { true, false, true, false, true, false };
        CollectionAssert.AreEqual(bool_coll, new DataService().GetCompareOperations(1025, 275));
    }
}