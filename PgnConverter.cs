using System.Text.RegularExpressions;

namespace PgnConverter
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

                return new Pgn
                {
                    Event = Regex.Match(pgnText, PgnRegexCatch.Event).Groups[1].Value,
                    Site = Regex.Match(pgnText, PgnRegexCatch.Site).Groups[1].Value,
                    Date = Regex.Match(pgnText, PgnRegexCatch.Date).Groups[1].Value,
                    Round = Regex.Match(pgnText, PgnRegexCatch.Round).Groups[1].Value,
                    White = Regex.Match(pgnText, PgnRegexCatch.White).Groups[1].Value,
                    Black = Regex.Match(pgnText, PgnRegexCatch.Black).Groups[1].Value,
                    Result = Regex.Match(pgnText, PgnRegexCatch.Result).Groups[1].Value,
                    WhiteElo = Regex.Match(pgnText, PgnRegexCatch.WhiteElo).Groups[1].Value,
                    WhiteTitle = Regex.Match(pgnText, PgnRegexCatch.WhiteTitle).Groups[1].Value,
                    WhiteFideId = Regex.Match(pgnText, PgnRegexCatch.WhiteFideId).Groups[1].Value,
                    BlackElo = Regex.Match(pgnText, PgnRegexCatch.BlackElo).Groups[1].Value,
                    BlackTitle = Regex.Match(pgnText, PgnRegexCatch.BlackTitle).Groups[1].Value,
                    BlackFideId = Regex.Match(pgnText, PgnRegexCatch.BlackFideId).Groups[1].Value,
                    Variant = Regex.Match(pgnText, PgnRegexCatch.Variant).Groups[1].Value,
                    Opening = Regex.Match(pgnText, PgnRegexCatch.Opening).Groups[1].Value,
                    Moves = movesMultiple,
                    PgnView = pgnText
                };
            });
        }
    }
}
