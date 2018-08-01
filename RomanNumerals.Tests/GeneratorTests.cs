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
    }
}
