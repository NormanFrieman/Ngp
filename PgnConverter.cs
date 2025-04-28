using System.Text.RegularExpressions;
using PgnConverterProject.Models;
using PgnConverterProject.RegexConsts;

namespace PgnConverterProject
{
    public static class PgnConverter
    {
        private static readonly string removeTimeRegex = "\\{\\s*\\[\\%.*?\\]\\s*\\}";
        private static readonly string pgnBlock = @"(?=\[Event\s+"".*?""\])((?:\[[^\]]+\]\r?\n?)*?(?:\r?\n)+((?:\d+\..*?)(?=\r?\n\r?\n|\[Event\s+|$))?)";

        public static IEnumerable<Pgn> Convert(string pgnStr)
        {
            var pgnStrClean = Regex.Replace(pgnStr, removeTimeRegex, "");
            var matches = Regex.Matches(pgnStrClean, pgnBlock, RegexOptions.Singleline);

            return matches.Select(x =>
            {
                var pgnText = x.Value;
                var movesUnique = Regex.Match(pgnText, PgnRegexCatch.MovesUnique).Groups[1].Value;
                var movesMultiple = Regex.Matches(movesUnique, PgnRegexCatch.MovesMultiple, RegexOptions.Singleline).Select(x => x.Groups[1].Value).ToArray();

                return new Pgn(pgnText, movesMultiple);
            });
        }
    }
}
