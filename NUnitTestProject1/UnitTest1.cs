using Moq;
using NUnit.Framework;
using WebApplication7.Repository;

namespace NUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(1, 1);
        }

        [Test]
        public void Mock()
        {
            var carMock = new Mock<ICarRepository>();


            Assert.AreEqual(1, 1);
        }


    }
}