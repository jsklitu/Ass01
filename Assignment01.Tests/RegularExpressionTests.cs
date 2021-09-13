using System.Collections.Generic; 
using Xunit;


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

        [Fact]
        public void test_resolution()
        {
            var resString = "1920x1080 1024x768 800x600";

            var actual = RegExpr.Resolution(resString);
            var expected = new (int width, int height)[] {(width: 1920, height: 1080), (width: 1024, height: 768), (width: 800, height: 600)}; 

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void test_innerText_a() {
            var htmlA = @"<div>
                            <p>A <b>regular expression</b>, <b>regex</b> or <b>regexp</b> (sometimes called a <b>rational expression</b>) is, in <a href='/wiki/Theoretical_computer_science' title='Theoretical computer science'>theoretical computer science</a> and <a href='/wiki/Formal_language' title='Formal language'>formal language</a> theory, a sequence of <a href='/wiki/Character_(computing)' title='Character (computing)'>characters</a> that define a <i>search <a href='/wiki/Pattern_matching' title='Pattern matching'>pattern</a></i>. Usually this pattern is then used by <a href='/wiki/String_searching_algorithm' title='String searching algorithm'>string searching algorithms</a> for 'find' or 'find and replace' operations on <a href='/wiki/String_(computer_science)' title='String (computer science)'>strings</a>.</p>
                        </div>";

            var expected = new string[] {"theoretical computer science", "formal language","characters","pattern","string searching algorithms","strings"};

            var actual = RegExpr.InnerText(htmlA, "a");
            
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void test_innerText_p() {
             var htmlP = @"<div>
                            <p>The phrase <i>regular expressions</i> (and consequently, regexes) is often used to mean the specific, standard textual syntax for representing <u>patterns</u> that matching <em>text</em> need to conform to.</p>
                        </div>";

            var expected = new string[] {"The phrase regular expressions (and consequently, regexes) is often used to mean the specific, standard textual syntax for representing patterns that matching text need to conform to."};

            var actual = RegExpr.InnerText(htmlP, "p");
            
            Assert.Equal(expected, actual);
        }
    }
}
