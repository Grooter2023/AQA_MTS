using NUnit.Framework;
using NUnitProject;

namespace NUnitTest;
[TestFixture]
public class TestCalc
    {
    [Test, Order(1)]
    [Description("Checks for successful division method Div(double).")]
    [Category("Smoke")]
    [Severity(SeverityLevel.Major)]
    [Repeat(5)]
    [TestCase(8.8, 4.4, 2.0)]
    public void TestDouble(double x, double y, double reference)
    {
        Calculator calculator1 = new Calculator();
        double result = calculator1.Div(x, y);
        Assert.That(reference, Is.EqualTo(result));
    }

    [Test, Order(2)]
    [Description("Checks for successful division method Div(int).")]
    [Category("Smoke")]
    [Severity(SeverityLevel.Major)]
    [TestCase(6, 2, 3)]
    [TestCase(8, 4, 2)]
    [TestCase(2, 1, 2)]
    public void TestInt(int x, int y, int reference)
    {
        Calculator calculator = new Calculator();
        int result = calculator.Div(x, y);
        Assert.That(reference,Is.EqualTo(result));
    }

    [Test, Order(3), Pairwise]
    [Description("Checks for successful division pairwise method Div(int).")]
    [Category("Smoke")]
    [Severity(SeverityLevel.Trivial)]
    [Retry(3)]
    public void RetryPairwiseTest(
        [Values(8, 4, 2)] int x,
        [Values(2, 2, 1)] int y)
    {
        Calculator calculator2 = new Calculator();
        int result = calculator2.Div(x, y);
        Assert.That(x/y, Is.EqualTo(result));
    }

    [Test, Order(4)]
    [Description("Сheck for division by zero test for method Div(int).")]
    [Category("Smoke")]
    [Severity(SeverityLevel.Trivial)]
    public void TestDivideZero()
    {
        Calculator calculator = new Calculator();

        try
        {
            var result = calculator.Div(6, 0);
        }
        catch (ArgumentException e)
        {
            Assert.That("Cannot divide by zero!", Is.EqualTo(e.Message));
        }
    }
}


