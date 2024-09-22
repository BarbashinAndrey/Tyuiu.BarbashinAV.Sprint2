using Tyuiu.BarbashinAV.Sprint2.Task7.V6.Lib; 
 
namespace Tyuiu.BarbashinAV.Sprint2.Task7.V6.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void CheckDotInShadedArea()  
   {
        double x = -1.5;
        double y = 0.8;

        Assert.AreEqual(true, new DataService().CheckDotInShadedArea(x, y));
   } 
} 
