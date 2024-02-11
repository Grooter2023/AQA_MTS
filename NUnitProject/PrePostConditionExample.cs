namespace NUnitTest;

public class PrePostConditionExample
{
    private int i = 0;
    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        Console.WriteLine($"{this}: OneTimeSetUp...{++i}");
    }

    [SetUp]
    public void Setup1()
    {
        Console.WriteLine($"{this}: SetUp...{++i}");
    }
  
    [Test]
    public void Test1()
    {
        Console.WriteLine($"{this}: Test...{++i}");
    }
   
    [SetUp]
    public void Setup2()
    {
        Console.WriteLine($"{this}: SetUp...{++i}");
    }
    [Test]
    public void Test2()
    {
        Console.WriteLine($"{this}: Test...{++i}");
    }

    [TearDown]
    public void TearDown()
    {
        Console.WriteLine($"{this}: TearDown...{++i}");
    }
  
    [OneTimeTearDown]
    public void OneTimeTearDown()
    {
        Console.WriteLine($"{this}: OneTimeTearDown...{++i}");
    }
}