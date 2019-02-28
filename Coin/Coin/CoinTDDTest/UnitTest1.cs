using System;
using Xunit;
using CoinTDD;

namespace CoinTDDTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestNumber1ShouldReturn1()
        {
            var contrller = new Coin();
            var result = contrller.CalculateCoinForNumber(1);
            Assert.Equal(1,result);
        }

        [Fact]
        public void Test2ShouldReturn1()
        {
            var contrller = new Coin();
            var result = contrller.CalculateCoinForNumber(2);
            Assert.Equal(1,result);
        }

        [Fact]
        public void Test3ShouldReturn1()
        {
            var contrller = new Coin();
            var result = contrller.CalculateCoinForNumber(3);
            Assert.Equal(1,result);
        }

        [Fact]
        public void Test4ShouldReturn2()
        {
            var contrller = new Coin();
            var result = contrller.CalculateCoinForNumber(4);
            Assert.Equal(2,result);
        }

        [Fact]
        public void Test5ShouldReturn2()
        {
            var contrller = new Coin();
            var result = contrller.CalculateCoinForNumber(5);
            Assert.Equal(2,result);
        }

        [Fact]
        public void Test6ShouldReturn3()
        {
            var contrller = new Coin();
            var result = contrller.CalculateCoinForNumber(6);
            Assert.Equal(3,result);
        }

        [Fact]
        public void Test7ShouldReturn4()
        {
            var contrller = new Coin();
            var result = contrller.CalculateCoinForNumber(7);
            Assert.Equal(4,result);
        }

        [Fact]
        public void Test8ShouldReturn4()
        {
            var contrller = new Coin();
            var result = contrller.CalculateCoinForNumber(8);
            Assert.Equal(4,result);
        }

        [Fact]
        public void Test9ShouldReturn4()
        {
            var contrller = new Coin();
            var result = contrller.CalculateCoinForNumber(9);
            Assert.Equal(4,result);
        }
    }
}
