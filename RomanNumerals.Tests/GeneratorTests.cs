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
            var result = generator.Generate(6);
            Assert.AreEqual(expected: "VI", actual: result);
        }

        [TestMethod]
        public void Generate_Eight()
        {
            var result = generator.Generate(8);
            Assert.AreEqual(expected: "VIII", actual: result);
        }

        [TestMethod]
        public void Generate_Ten()
        {
            var result = generator.Generate(10);
            Assert.AreEqual(expected: "X", actual: result);
        }

        [TestMethod]
        public void Generate_Twenty()
        {
            var result = generator.Generate(20);
            Assert.AreEqual(expected: "XX", actual: result);
        }

        [TestMethod]
        public void Generate_TwentyOne()
        {
            var result = generator.Generate(21);
            Assert.AreEqual(expected: "XXI", actual: result);
        }

        [TestMethod]
        public void Generate_TwentySeven()
        {
            var result = generator.Generate(27);
            Assert.AreEqual(expected: "XXVII", actual: result);
        }

        [TestMethod]
        public void Generate_FiftyOne()
        {
            var result = generator.Generate(51);
            Assert.AreEqual(expected: "LI", actual: result);
        }

        [TestMethod]
        public void Generate_OneHundredTwentyEight()
        {
            var result = generator.Generate(128);
            Assert.AreEqual(expected: "CXXVIII", actual: result);
        }

        [TestMethod]
        public void Generate_SixHundredThirtySix()
        {
            var result = generator.Generate(636);
            Assert.AreEqual(expected: "DCXXXVI", actual: result);
        }

        [TestMethod]
        public void Generate_TwoThousandSixHundredThirtySix()
        {
            var result = generator.Generate(2636);
            Assert.AreEqual(expected: "MMDCXXXVI", actual: result);
        }
    }
}
