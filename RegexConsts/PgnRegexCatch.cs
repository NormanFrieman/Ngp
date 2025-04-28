namespace PgnConverterProject.RegexConsts
{
    internal static class PgnRegexCatch
    {
        public const string Event = "\\[Event\\s+\"(.*?)\"\\]";
        public const string Site = "\\[Site\\s+\"(.*?)\"\\]";
        public const string Date = "\\[Date\\s+\"(.*?)\"\\]";
        public const string Round = "\\[Round\\s+\"(.*?)\"\\]";
        public const string White = "\\[White\\s+\"(.*?)\"\\]";
        public const string Black = "\\[Black\\s+\"(.*?)\"\\]";
        public const string Result = "\\[Result\\s+\"(.*?)\"\\]";
        public const string WhiteElo = "\\[WhiteElo\\s+\"(.*?)\"\\]";
        public const string WhiteTitle = "\\[WhiteTitle\\s+\"(.*?)\"\\]";
        public const string WhiteFideId = "\\[WhiteFideId\\s+\"(.*?)\"\\]";
        public const string BlackElo = "\\[BlackElo\\s+\"(.*?)\"\\]";
        public const string BlackTitle = "\\[BlackTitle\\s+\"(.*?)\"\\]";
        public const string BlackFideId = "\\[BlackFideId\\s+\"(.*?)\"\\]";
        public const string Variant = "\\[Variant\\s+\"(.*?)\"\\]";
        public const string Opening = "\\[Opening\\s+\"(.*?)\"\\]";
        public const string MovesUnique = "(?:\\[\\w+ \\\"[^\\\"]*\\\"\\]\\s*)+\\s*(.*)";
        public const string MovesMultiple = "\\d+\\.*\\.*\\s+([a-hRNBQKO0-8x=+#-]+)";
    }
}
