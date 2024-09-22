using Tyuiu.BarbashinAV.Sprint2.Task6.V11.Lib; 
 
namespace Tyuiu.BarbashinAV.Sprint2.Task6.V11.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidDateOfNextDay()  
   {
        var ds = new DataService();

        Assert.AreEqual("23.09.2024", ds.FindDateOfNextDay(2024, 9, 22));
        Assert.AreEqual("01.10.2024", ds.FindDateOfNextDay(2024, 9, 30));
        Assert.AreEqual("01.11.2024", ds.FindDateOfNextDay(2024, 10, 31));
        Assert.AreEqual("01.03.2024", ds.FindDateOfNextDay(2024, 2, 28));

        Assert.ThrowsException<ArgumentException>(() => ds.FindDateOfNextDay(2024, 2, 30));
        Assert.ThrowsException<ArgumentException>(() => ds.FindDateOfNextDay(2024, 13, 30));
    } 
} 
