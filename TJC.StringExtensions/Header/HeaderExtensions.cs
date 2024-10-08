﻿using TJC.StringExtensions.Lines;
using TJC.StringExtensions.Padding;

namespace TJC.StringExtensions.Header
{
    public static class HeaderExtensions
    {
        public static IEnumerable<string> GenerateHeader(this IEnumerable<string> lines, int internalLineLimit = 70, char character = '#', string linePrefix = "###   ", string lineSuffix = "   ###")
        {
            var tempLines = new List<string>();
            // Get lines
            foreach (var newLine in lines)
                foreach (var splitLine in newLine.SplitNewLine())
                    foreach (var line in splitLine.SplitLines(internalLineLimit))
                        tempLines.Add(line);

            // Get border
            var longestLine = tempLines.Max(x => x.Length);
            var headerBorder = new string(character, longestLine + linePrefix.Length + lineSuffix.Length);

            // Get lines with prefix and suffix
            var headerLines = new List<string> { headerBorder };
            foreach (var line in tempLines)
                headerLines.Add($"{linePrefix}{line.PadBoth(longestLine)}{lineSuffix}");
            headerLines.Add(headerBorder);
            return headerLines;
        }
    }
}