using System.Reflection;
using Xunit;

namespace FooBarQix.Tests
{
    public class FooBarQixDeterminerTest
    {
        [Fact]
        public void Test1()
        {
            int number = 3;

            ToString("Foo");
        }
    }
}