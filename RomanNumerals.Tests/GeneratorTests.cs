using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumerals;
using System;
using System.Collections.Generic;

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

        [TestMethod]
        public void Generate_Four()
        {
            var result = generator.Generate(4);
            Assert.AreEqual(expected: "IV", actual: result);
        }

        [TestMethod]
        public void Generate_FortyFour()
        {
            var result = generator.Generate(44);
            Assert.AreEqual(expected: "XLIV", actual: result);
        }

        [TestMethod]
        public void Generate_FourHundreadFortyFour()
        {
            var result = generator.Generate(444);
            Assert.AreEqual(expected: "CDXLIV", actual: result);
        }

        [TestMethod]
        public void Generate_Nine()
        {
            var result = generator.Generate(9);
            Assert.AreEqual(expected: "IX", actual: result);
        }

        [TestMethod]
        public void Generate_NinetyNine()
        {
            var result = generator.Generate(99);
            Assert.AreEqual(expected: "XCIX", actual: result);
        }

        [TestMethod]
        public void Generate_NineHundreadNinetyNine()
        {
            var result = generator.Generate(999);
            Assert.AreEqual(expected: "CMXCIX", actual: result);
        }

        [TestMethod]
        public void Generate_TestExtremes_Valid()
        {
            var romanNumerals = new Dictionary<int, string>
            {
                {1, "I"},
                {3999, "MMMCMXCIX"},
            };

            TestPairs(romanNumerals);            
        }

        [TestMethod]
        public void Generate_TestExtremes_Invalid()
        {
            var numbers = new int[] {0, 4000, int.MaxValue, int.MinValue};

            foreach (var number in numbers)
            {
                try
                {
                    generator.Generate(number);
                }
                catch (ArgumentException ex)
                {
                    Assert.AreEqual(expected: $"Invalid input of {number}, input must be in the range of 1 - 3999 inclusive.", actual: ex.Message);
                    continue;
                }
                catch
                {
                    Assert.Fail("Invalid exception thrown.");
                }
                
                Assert.Fail("No exception thrown.");
            }      
        }

        [TestMethod]
        public void Generate_RandomValues()
        {
            var romanNumerals = new Dictionary<int, string>
            {
                {1675, "MDCLXXV"},
                {3045, "MMMXLV"},
                {1897, "MDCCCXCVII"},
                {185, "CLXXXV"},
                {2246, "MMCCXLVI"},
            };

            TestPairs(romanNumerals);            
        }

        private void TestPairs(Dictionary<int, string> romanNumerals)
        {
            foreach (var pairs in romanNumerals)
            {
                TestPair(pairs.Key, pairs.Value);
            }
        }

        private void TestPair(int number, string expectedNumerals)
        {
            var result = generator.Generate(number);
            Assert.AreEqual(expected: expectedNumerals, actual: result);
        }
    }
}
