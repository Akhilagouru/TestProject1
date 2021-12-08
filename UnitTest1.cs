using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        public IWebdriver driver;
        [SetUp]
        public void Setup()
        {
            print("Hello");
            print("Haiiii")
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}