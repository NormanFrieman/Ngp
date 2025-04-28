using PgnConverterProject;

namespace PgnConverterTest
{
    public class PgnConverterTest
    {
        [Fact]
        public void Convert_Success()
        {
            // Act
            var pgn = PgnConverter.Convert(pgnStr).Single();

            // Assert
            Assert.Equal("Round 2: Dardha, Daniel - Bettalli, Francesco", pgn.Event);
            Assert.Equal("https://lichess.org/broadcast/-/-/3FTNKv1L", pgn.Site);
            Assert.Equal("2025.04.27", pgn.Date);
            Assert.Equal("2.1", pgn.Round);
            Assert.Equal("Dardha, Daniel", pgn.White);
            Assert.Equal("Bettalli, Francesco", pgn.Black);
            Assert.Equal("0-1", pgn.Result);
            Assert.Equal("2650", pgn.WhiteElo);
            Assert.Equal("GM", pgn.WhiteTitle);
            Assert.Equal("240990", pgn.WhiteFideId);
            Assert.Equal("2355", pgn.BlackElo);
            Assert.Equal("FM", pgn.BlackTitle);
            Assert.Equal("2816453", pgn.BlackFideId);
            Assert.Equal("Standard", pgn.Variant);
            Assert.Equal("Sicilian Defense: Nyezhmetdinov-Rossolimo Attack", pgn.Opening);
            Assert.Equal(new List<string>() { "e4", "c5", "Nf3", "Nc6" }, pgn.Moves);
            Assert.Equal(pgnExpectedStr, pgn.PgnView);
        }

        #region Helpers
        private static readonly string pgnStr = @"[Event ""Round 2: Dardha, Daniel - Bettalli, Francesco""]
[Site ""https://lichess.org/broadcast/-/-/3FTNKv1L""]
[Date ""2025.04.27""]
[Round ""2.1""]
[White ""Dardha, Daniel""]
[Black ""Bettalli, Francesco""]
[Result ""0-1""]
[WhiteElo ""2650""]
[WhiteTitle ""GM""]
[WhiteFideId ""240990""]
[BlackElo ""2355""]
[BlackTitle ""FM""]
[BlackFideId ""2816453""]
[Variant ""Standard""]
[ECO ""B30""]
[Opening ""Sicilian Defense: Nyezhmetdinov-Rossolimo Attack""]
[Annotator ""https://lichess.org/broadcast/-/-/3FTNKv1L""]
[StudyName ""Round 2""]
[ChapterName ""Dardha, Daniel - Bettalli, Francesco""]

1. e4 { [%clk 1:27:25] } 1... c5 { [%clk 1:30:50] } 2. Nf3 { [%clk 1:27:48] } 2... Nc6 0-1";

        private static readonly string pgnExpectedStr = @"[Event ""Round 2: Dardha, Daniel - Bettalli, Francesco""]
[Site ""https://lichess.org/broadcast/-/-/3FTNKv1L""]
[Date ""2025.04.27""]
[Round ""2.1""]
[White ""Dardha, Daniel""]
[Black ""Bettalli, Francesco""]
[Result ""0-1""]
[WhiteElo ""2650""]
[WhiteTitle ""GM""]
[WhiteFideId ""240990""]
[BlackElo ""2355""]
[BlackTitle ""FM""]
[BlackFideId ""2816453""]
[Variant ""Standard""]
[ECO ""B30""]
[Opening ""Sicilian Defense: Nyezhmetdinov-Rossolimo Attack""]
[Annotator ""https://lichess.org/broadcast/-/-/3FTNKv1L""]
[StudyName ""Round 2""]
[ChapterName ""Dardha, Daniel - Bettalli, Francesco""]

1. e4  1... c5  2. Nf3  2... Nc6 0-1";
        #endregion
    }
}