using System;
using System.Collections.Generic; 
using Xunit;
using Assignment01;

namespace Assignment01.Tests
{
    public class RegularExpressionTests
    {
        [Fact]
        public void test_split()
        {
            var listOfString = new List<string>() {"testing if it works", "hey there"};

            var actual = RegExpr.SplitLine(listOfString);
            var expected = new List<string>() {"testing", "if", "it", "works", "hey", "there"};

            Assert.Equal(expected, actual);
        }
    }
}
