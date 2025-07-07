using Antlr4.Runtime;
using NgpConverter.Generated;
using NgpConverter.Models;
using System.Text.RegularExpressions;

namespace NgpConverter
{
    public static class PgnCompiler
    {
        private static readonly string _removeBrace = "\\{[^{}]*\\}|\\([^()]*\\)";
        private static readonly string _removeParen = "[!?]";

        private static readonly string _pgnBlock = @"(?=\[Event\s+"".*?""\])((?:\[[^\]]+\]\r?\n?)*?(?:\r?\n)+((?:\d+\..*?)(?=\r?\n\r?\n|\[Event\s+|$))?)";
        
        private static readonly string _movesUnique = "(?:\\[\\w+ \\\"[^\\\"]*\\\"\\]\\s*)+\\s*(.*)";
        private static readonly string _movesMultiple = "\\b(?:[KQRBN]?[a-h]?[1-8]?x?[a-h][1-8]|O-O(?:-O)?)\\+?#?\\b";

        public static Pgn[] Compile(string pgnStr)
        {
            try
            {
                var pgnWithoutBrace = Regex.Replace(pgnStr, _removeBrace, "");
                var pgnClean = Regex.Replace(pgnWithoutBrace, _removeParen, "");
                var matches = Regex.Matches(pgnClean, _pgnBlock, RegexOptions.Singleline);

                var pgns = new List<Pgn>();
                foreach (Match match in matches)
                {
                    var movesUnique = Regex.Match(pgnClean, _movesUnique)
                        .Groups[1]
                        .Value;
                    var movesMultiple = Regex.Matches(movesUnique, _movesMultiple, RegexOptions.Singleline)
                        .Select(x => x.Groups[0].Value)
                        .ToArray();

                    var antlrInput = new AntlrInputStream(match.Value);
                    var lexer = new PgnLexer(antlrInput);
                    var tokens = new CommonTokenStream(lexer);

                    var parser = new PgnParser(tokens);
                    var tree = parser.pgn_info();

                    var checker = new PgnChecker();
                    checker.Visit(tree);

                    var pgn = checker.Pgn;
                    pgn.PgnView = match.Value;
                    pgn.Moves = movesMultiple;

                    pgns.Add(checker.Pgn);
                }

                return [.. pgns];
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
    }
}
