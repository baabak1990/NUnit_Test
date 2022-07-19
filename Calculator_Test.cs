using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace NUnit_Test
{
    [TestFixture]
    public class Calculator_Test
    {
        [Test]
        public void Add_ScenarioSum_EquilSun_A_B()
        {
            //Arrange
            var cal = new Calculator();
            //Act
            var res = cal.Sum(1, 2);
            //Assert
            Assert.That(res, Is.EqualTo(3));
        }

        [Test]
        public void Max_ScenarioFirstArgumnetIsGreater_ReturFirst()
        {
            var cal = new Calculator();
            var res = cal.Max(1, 3);
            Assert.That(res, Is.EqualTo(3));
        }


        [Test]
        public void Max_ScenarioSecondArgumnetIsGreater_ReturSecond()
        {
            var cal = new Calculator();
            var res = cal.Max(5, 3);
            Assert.That(res == 5);
        }


        [Test]
        public void Max_ScenarioArgumnetsAreEquil_ReturSame()
        {
            var cal = new Calculator();
            var res = cal.Max(3, 3);
            Assert.That(res==3);
        }
    }
}