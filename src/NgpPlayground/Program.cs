using NgpConverter;

namespace NgpPlayground
{
    public class Program
    {
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
[ChapterName ""Dardha, Daniel - Bettalli, Francesco""]";

        static void Main(string[] args)
        {
            var pgns = Ngp.Convert(pgnStr);

            foreach (var pgn in pgns)
            {
                Console.WriteLine(pgn.Event);
                Console.WriteLine(pgn.Opening);
            }
        }
    }
}
