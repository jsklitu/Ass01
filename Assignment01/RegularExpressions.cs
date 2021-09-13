using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Assignment01
{
    public static class RegExpr
    {
        public static IEnumerable<string> SplitLine(IEnumerable<string> lines)
        {
            var regex = new Regex("([a-zA-Z0-9]+)");
            foreach (var line in lines) {
                var match = regex.Match(line);
                for (; match.Success ; match = match.NextMatch())
                {
                    yield return match.Value;
                }
            }
        }

        public static IEnumerable<(int width, int height)> Resolution(string resolutions)
        {
            var regex = new Regex(@"(?'width'\d+)x(?'height'\d+)");
            var match = regex.Match(resolutions);
            for(; match.Success ; match = match.NextMatch())
            {   
                yield return (Int32.Parse(match.Groups["width"].Value), Int32.Parse(match.Groups["height"].Value));
            }
        }

        public static IEnumerable<string> InnerText(string html, string tag)
        {
            Regex extractTag = new Regex(@"<" + tag + @">(.*)<\/" + tag + @">");
            Regex stripNestedTags = new Regex(@"<[^>]*>");

            String extractedString = extractTag.Match(html).ToString();
            Match nestedMatch = stripNestedTags.Match(extractedString);

            StringBuilder s = new StringBuilder();

            for(; nestedMatch.Success ; nestedMatch = nestedMatch.NextMatch()) {
                
                s.Append(nestedMatch + " ");

            }
            var result = s.ToString(); 

            yield return result;
        }
    }
}
