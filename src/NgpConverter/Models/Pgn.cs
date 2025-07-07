namespace NgpConverter.Models
{
    public class Pgn
    {
        public string Event { get; set; }
        public string Site { get; set; }
        public string Date { get; set; }
        public string Round { get; set; }
        public string White { get; set; }
        public string Black { get; set; }
        public string Result { get; set; }
        public string GameId { get; set; }

        public string WhiteElo { get; set; }
        public string WhiteTitle { get; set; }
        public string WhiteFideId { get; set; }
        public string BlackElo { get; set; }
        public string BlackTitle { get; set; }
        public string BlackFideId { get; set; }

        public string Variant { get; set; }
        public string Opening { get; set; }

        public string TimeControl { get; set; }
        public string ECO { get; set; }

        public string Termination { get; set; }
        public string Annotator { get; set; }
        public string StudyName { get; set; }
        public string ChapterName { get; set; }

        public IEnumerable<string> Moves { get; set; }
        public string PgnView { get; set; }
    }
}
