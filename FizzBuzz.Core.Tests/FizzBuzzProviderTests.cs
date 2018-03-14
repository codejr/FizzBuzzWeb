using System;
using FizzBuzz.Core;
using Xunit;

namespace FizzBuzz.Core.Tests
{
    public class FizzBuzzProviderTests
    {
        [Fact]
        public void TestSingleBuzz()
        {
            var provider = new FizzBuzzProvider();
            var result = provider.GetFizzBuzzSingle(5);
            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void TestSingleFizz()
        {
            var provider = new FizzBuzzProvider();
            var result = provider.GetFizzBuzzSingle(9);
            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void TestSingleNone()
        {
            var provider = new FizzBuzzProvider();
            var result = provider.GetFizzBuzzSingle(7);
            Assert.Equal("7", result);
        }

        [Fact]
        public void TestMultiEmpty()
        {
            var provider = new FizzBuzzProvider();
            var result = provider.GetFizzBuzzMulti(0);
            Assert.Empty(result);
        }

        [Fact]
        public void TestMultiUpTo15()
        {
            var provider = new FizzBuzzProvider();
            var expected = new[]
            {
                "1",
                "2",
                "Fizz",
                "4",
                "Buzz",
                "Fizz",
                "7",
                "8",
                "Fizz",
                "Buzz",
                "11",
                "Fizz",
                "13",
                "14",
                "FizzBuzz"
            };
            var result = provider.GetFizzBuzzMulti(15);
            Assert.Equal(result, expected);
        }

        [Fact]
        public void TestMultiInvalidNegatives()
        {
            var provider = new FizzBuzzProvider();
            Assert.Throws<ArgumentOutOfRangeException>(() => provider.GetFizzBuzzMulti(-1));
        }

        [Fact]
        public void TestMultiInvalidTooHigh()
        {
            var provider = new FizzBuzzProvider();
            Assert.Throws<ArgumentOutOfRangeException>(() => provider.GetFizzBuzzMulti(int.MaxValue));
        }
    }
}
