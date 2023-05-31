namespace WebApiTests.Controllers;

// add a namespace for the weatherforecast controller
using WebApi.Controllers;

[TestClass]
public class WeatherForecastControllerTests
{
    [TestMethod]
    public void TestMethod1()
    {
    }

    // add a new test method that tests the GetRange action method of the WeatherForecastController
    // use datatestmethod attribute to pass in a range of values
    [DataTestMethod]
    [DataRow(1)]
    [DataRow(2)]
    [DataRow(3)]
    [DataRow(4)]
    [DataRow(5)]    
    public void TestMethod2(int length)
    {
        // arrange
        var controller = new WeatherForecastController(null);

        // act
        var result = controller.GetRange(new DateRange {Length = length});

        // assert
        Assert.AreEqual(length, result.Count());
    }
}