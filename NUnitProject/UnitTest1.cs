namespace NUnitProject
{
    public class Tests  
    {
        [Test]
        public void Test0()
        {
            Console.WriteLine($"{this}: Test...");
            Assert.Pass();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}


