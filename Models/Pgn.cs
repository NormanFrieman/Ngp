using System.Text.RegularExpressions;
using PgnConverterProject.RegexConsts;

namespace PgnConverterProject.Models
{
    public class Pgn(string pgnStr, string[] moves)
    {
        public string Event { get; set; } = Regex.Match(pgnStr, PgnRegexCatch.Event).Groups[1].Value;
        public string Site { get; set; } = Regex.Match(pgnStr, PgnRegexCatch.Site).Groups[1].Value;
        public string Date { get; set; } = Regex.Match(pgnStr, PgnRegexCatch.Date).Groups[1].Value;
        public string Round { get; set; } = Regex.Match(pgnStr, PgnRegexCatch.Round).Groups[1].Value;
        public string White { get; set; } = Regex.Match(pgnStr, PgnRegexCatch.White).Groups[1].Value;
        public string Black { get; set; } = Regex.Match(pgnStr, PgnRegexCatch.Black).Groups[1].Value;
        public string Result { get; set; } = Regex.Match(pgnStr, PgnRegexCatch.Result).Groups[1].Value;
        public string WhiteElo { get; set; } = Regex.Match(pgnStr, PgnRegexCatch.WhiteElo).Groups[1].Value;
        public string WhiteTitle { get; set; } = Regex.Match(pgnStr, PgnRegexCatch.WhiteTitle).Groups[1].Value;
        public string WhiteFideId { get; set; } = Regex.Match(pgnStr, PgnRegexCatch.WhiteFideId).Groups[1].Value;
        public string BlackElo { get; set; } = Regex.Match(pgnStr, PgnRegexCatch.BlackElo).Groups[1].Value;
        public string BlackTitle { get; set; } = Regex.Match(pgnStr, PgnRegexCatch.BlackTitle).Groups[1].Value;
        public string BlackFideId { get; set; } = Regex.Match(pgnStr, PgnRegexCatch.BlackFideId).Groups[1].Value;
        public string Variant { get; set; } = Regex.Match(pgnStr, PgnRegexCatch.Variant).Groups[1].Value;
        public string Opening { get; set; } = Regex.Match(pgnStr, PgnRegexCatch.Opening).Groups[1].Value;
        public IEnumerable<string> Moves { get; set; } = moves;
        public string PgnView { get; set; } = pgnStr;
    }
}
