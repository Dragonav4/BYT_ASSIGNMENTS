namespace Calculator.Tests;

[TestFixture]
public class CalculatorTests
{
    [TestCase(3, 3, "+", 6)]
    [TestCase(1.5, 2.5, "+", 4.0)]
    [TestCase(3, 3, "-", 0)]
    [TestCase(4, 4, "*", 16)]
    [TestCase(2, 2, "/", 1)]
    public void CalculateValidOperationsReturnsExpectedValues(double a, double b, string op, double expected)
    {
        var calculator = new Calculator(a, b, op);
        var result = calculator.Calculate();
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void CalculateDivideByZeroThrowsDivideByZeroException()
    {
        var calc = new Calculator(5, 0, "/");
        Assert.That(() => calc.Calculate(), Throws.TypeOf<DivideByZeroException>());
    }

    [Test]
    public void CalculateInvalidOperationThrows()
    {
        var calc = new Calculator(3, 3, "%");
        Assert.That(() => calc.Calculate(), Throws.TypeOf<ArgumentException>());
    }
}