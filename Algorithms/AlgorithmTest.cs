using System;
using Xunit;

namespace DeveloperSample.Algorithms
{
    public class AlgorithmTest
    {

        [Fact]
        public void CanGetFactorial_InputIsZero_ReturnOne()
        {
            Assert.Equal(1, Algorithms.GetFactorial(0));
        }

        [Fact]
        public void CanGetFactorial_InputIsPositiveInteger_ReturnCorrectFactorial()
        {
            Assert.Equal(1, Algorithms.GetFactorial(1));
            Assert.Equal(2, Algorithms.GetFactorial(2));
            Assert.Equal(6, Algorithms.GetFactorial(3));
            Assert.Equal(24, Algorithms.GetFactorial(4));
        }

        [Fact]
        public void CanGetFactorial_InputIsNegativeInteger_ThrowArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Algorithms.GetFactorial(-1));
        }

        [Fact]
        public void CanFormatSeparators_InputIsEmpty_ReturnEmptyString()
        {
            Assert.Equal("", Algorithms.FormatSeparators());
        }

        [Fact]
        public void CanFormatSeparators_InputContainsOneItem_ReturnTheItem()
        {
            Assert.Equal("a", Algorithms.FormatSeparators("a"));
        }

        [Fact]
        public void CanFormatSeparators_InputContainsMultipleItems_ReturnTheItemsWithCommasAndAnd()
        {
            Assert.Equal("a, b and c", Algorithms.FormatSeparators("a", "b", "c"));
        }
    }
}