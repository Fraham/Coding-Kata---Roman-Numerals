using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumerals;

namespace RomanNumerals.Tests
{
    [TestClass]
    public class GeneratorTests
    {
        RomanNumeralGenerator generator = new RomanNumeralGenerator();

        [TestMethod]
        public void Generate_One()
        {
            var result = generator.Generate(1);
            Assert.AreEqual(expected: "I", actual: result);
        }

        [TestMethod]
        public void Generate_Two()
        {
            var result = generator.Generate(2);
            Assert.AreEqual(expected: "II", actual: result);
        }

        [TestMethod]
        public void Generate_Five()
        {
            var result = generator.Generate(5);
            Assert.AreEqual(expected: "V", actual: result);
        }

        [TestMethod]
        public void Generate_Six()
        {
            var result = generator.Generate(5);
            Assert.AreEqual(expected: "VI", actual: result);
        }
    }
}
