using Moq;
using NUnit.Framework;

[TestFixture]
public class CalculatorTests
{
    [Test]
    public void Add_ReturnsCorrectSum()
    {
        
        var mockLogger = new Mock<ILogger>();
        var calculator = new Calculator(mockLogger.Object);

        
        int result = calculator.Add(10, 20);

        
        Assert.That(result, Is.EqualTo(30));

        
        mockLogger.Verify(x => x.Log("Addition performed"), Times.Once);
    }
}