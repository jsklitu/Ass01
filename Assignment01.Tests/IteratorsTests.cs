using System;
using System.Collections.Generic; 
using Xunit;
using Assignment01;

namespace Assignment01.Tests
{
    public class IteratorsTests
    {
        [Fact]
        public void test_flatten()
        {
            var listOfList = new List<List<int>>() {new List<int>() {1,2,3}, new List<int>() {4,5,6}};

            var actual = Iterators.Flatten<int>(listOfList);

            var expected = new List<int>() {1,2,3,4,5,6};

            Assert.Equal(expected, actual);
        }


        [Fact]
        public void test_filter()
        {
            Predicate<int> even = (i) => i % 2 == 0;

            var listOfInts = new List<int>() {1,2,3};

            var actual = Iterators.Filter<int>(listOfInts, even);
            var expected = new List<int>() {2};

            Assert.Equal(expected, actual);
        }
    }
}
