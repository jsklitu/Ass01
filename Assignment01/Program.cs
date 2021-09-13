using System;
using System.Collections.Generic;

namespace Assignment01
{
    class Program
    {
        static void Main(string[] args)
        {
            var html = @"
                <div><p>A <b>regular expression</b>, <b>regex</b> or <b>regexp</b> (sometimes called a <b>rational expression</b>) is, in <a href='/wiki/Theoretical_computer_science' title='Theoretical computer science'>theoretical computer science</a> and <a href='/wiki/Formal_language' title='Formal language'>formal language</a> theory, a sequence of <a href='/wiki/Character_(computing)' title='Character (computing)'>characters</a> that define a <i>search <a href='/wiki/Pattern_matching' title='Pattern matching'>pattern</a></i>. Usually this pattern is then used by <a href='/wiki/String_searching_algorithm' title='String searching algorithm'>string searching algorithms</a> for 'find' or 'find and replace' operations on <a href='/wiki/String_(computer_science)' title='String (computer science)'>strings</a>.</p></div>";

            var actual = RegExpr.InnerText(html, "p");

            foreach (var item in actual)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
