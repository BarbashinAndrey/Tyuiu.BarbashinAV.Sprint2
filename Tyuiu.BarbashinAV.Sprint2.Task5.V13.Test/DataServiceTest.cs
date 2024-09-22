using Tyuiu.BarbashinAV.Sprint2.Task5.V13.Lib; 
 
namespace Tyuiu.BarbashinAV.Sprint2.Task5.V13.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidDateOfNextDay()  
   {
        var ds = new DataService();

        Assert.AreEqual("23 сент€бр€, 2024", ds.FindDateOfNextDay(2024, 9, 22));
        Assert.AreEqual("1 окт€бр€, 2024", ds.FindDateOfNextDay(2024, 9, 30));
        Assert.AreEqual("1 но€бр€, 2024", ds.FindDateOfNextDay(2024, 10, 31));
        Assert.AreEqual("1 марта, 2024", ds.FindDateOfNextDay(2024, 2, 29));

        Assert.ThrowsException<ArgumentException>(() => ds.FindDateOfNextDay(2024, 2, 30));
        Assert.ThrowsException<ArgumentException>(() => ds.FindDateOfNextDay(2024, 13, 30));
    } 
} 
