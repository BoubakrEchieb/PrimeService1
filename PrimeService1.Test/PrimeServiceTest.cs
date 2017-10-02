using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PrimeService1.Test
{
    public class PrimeServiceTest
    {
        private readonly PrimeService _primeService;

        public PrimeServiceTest()
        {
            _primeService = new PrimeService();
        }

        [Fact]
        public void ReturnFalseGivenValueOf1()
        {
            var result = _primeService.IsPrime(1);

            Assert.False(result, "1 should not be prime");
        }
        [Theory]
        [ClassData(typeof(TestDataGenerator))]
        public void AllNumbers_AreOdd_WithInlineData(int a, int b, int c, int d)
        {
            Assert.True(_primeService.IsOddNumber(a));
            Assert.True(_primeService.IsOddNumber(b));
            Assert.True(_primeService.IsOddNumber(c));
            Assert.True(_primeService.IsOddNumber(d));
        }
        [Theory]
        [MemberData(nameof(TestDataGenerator_1.GetPersonFromDataGenerator), MemberType = typeof(TestDataGenerator_1))]
        public void AllPersons_AreAbove14(Person a, Person b, Person c, Person d)
        {
            Assert.True(a.IsAboveForTeen());
            Assert.True(b.IsAboveForTeen());
            Assert.True(c.IsAboveForTeen());
            Assert.True(d.IsAboveForTeen());
        }
    }
}
