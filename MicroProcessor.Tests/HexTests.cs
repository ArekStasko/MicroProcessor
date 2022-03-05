using NUnit.Framework;
using FluentAssertions;
using MicroProcessor;

namespace MicroProcessor.Tests
{
    public class HexTests
    {

        [Test]
        public void CheckCorrection_ShouldReturn_True()
        {
            string[] hexesToCheck = new string[] { "6f", "ff", "2a", "5f", "22", "3c" };

            foreach (var hex in hexesToCheck)
            {
                bool result = Program.CheckCorrection(hex);
                result.Should().BeTrue();
            }
        }

        [Test]
        public void CheckCorrection_ShouldReturn_False()
        {
            string[] hexesToCheck = new string[] { "qq", "xx", "dasf", "f", "-d", "kl" };

            foreach (var hex in hexesToCheck)
            {
                bool result = Program.CheckCorrection(hex);
                result.Should().BeFalse();
            }
        }
    }
}