using System.Reflection;
using Xunit;

namespace FooBarQix.Tests
{
    public class FooBarQixDeterminerTest
    {
        [Fact]
        public void Determine_ReturnNumberAsString() {
            int number = 1;
            FooBarQixDeterminer determiner = new FooBarQixDeterminer();

            var result = determiner.Determine(number);

            Assert.Equal("1", result);
        }

        [Fact]
        public void Determine_ReturnFoo()
        {
            int number = 3;
            FooBarQixDeterminer determiner = new FooBarQixDeterminer();
            var result = determiner.Determine(number);
            Assert.Equal("Foo", result);
        }

        [Fact]
        public void Determine_ReturnBar()
        {
            int number = 5;
            FooBarQixDeterminer determiner = new FooBarQixDeterminer();
            var result = determiner.Determine(number);
            Assert.Equal("Bar", result);
        }

        [Fact]
        public void Determine_ReturnQix()
        {
            int number = 7;
            FooBarQixDeterminer determiner = new FooBarQixDeterminer();
            var result = determiner.Determine(number);
            Assert.Equal("Qix", result);
        }

        [Fact]
        public void Determine_ReturnFooBar()
        {
            int number = 15;
            FooBarQixDeterminer determiner = new FooBarQixDeterminer();
            var result = determiner.Determine(number);
            Assert.Equal("FooBar", result);
        }

        [Fact]
        public void Determine_ReturnFooQix()
        {
            int number = 21;
            FooBarQixDeterminer determiner = new FooBarQixDeterminer();
            var result = determiner.Determine(number);
            Assert.Equal("FooQix", result);
        }

        [Fact]
        public void Determine_ReturnBarQix()
        {
            int number = 35;
            FooBarQixDeterminer determiner = new FooBarQixDeterminer();
            var result = determiner.Determine(number);
            Assert.Equal("BarQix", result);
        }

    }
}