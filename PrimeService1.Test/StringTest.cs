using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Extensions;

namespace PrimeService1.Test
{
    public class StringTest
    {
        public static IEnumerable<object[]> SplitCountData
        {
            get
            {
                // Or this could read from a file. :)
                return new[]
                {
                new object[] { "xUnit", 1 },
                new object[] { "is fun", 2 },
                new object[] { "to test with", 3 }
            };
            }
        }
        [Theory, InlineData("tt", "t", true), InlineData("azerty", "non", false)]
        public void Contains(string source, string sub, bool expected)
        {
            bool result = source.Contains(sub);
            Assert.Equal(result, expected);
        }
        [Theory, PropertyData("SplitCountData")]
        public  void SplitCount(string source, int expectedCount)
        {
            // Arrange
            // Act
            var actualCount = source.Split(' ').Count();
            // Assert
            Assert.Equal(actualCount, expectedCount);

        }
    }
}
