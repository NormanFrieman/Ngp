using Antlr4.Runtime;
using NgpCompiler.Generated;
using NgpCompiler.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace NgpCompiler
{
    public static class PgnCompiler
    {
        private static readonly string removeTimeRegex = "\\{\\s*\\[\\%.*?\\]\\s*\\}";
        private static readonly string pgnBlock = @"(?=\[Event\s+"".*?""\])((?:\[[^\]]+\]\r?\n?)*?(?:\r?\n)+((?:\d+\..*?)(?=\r?\n\r?\n|\[Event\s+|$))?)";

        public static Pgn[] Compile(string pgnStr)
        {
            try
            {
                var pgnClean = Regex.Replace(pgnStr, removeTimeRegex, "");
                var matches = Regex.Matches(pgnClean, pgnBlock, RegexOptions.Singleline);

                var pgns = new List<Pgn>();
                foreach (Match match in matches)
                {
                    var antlrInput = new AntlrInputStream(match.Value);
                    var lexer = new PgnLexer(antlrInput);
                    var tokens = new CommonTokenStream(lexer);

                    var parser = new PgnParser(tokens);
                    var tree = parser.pgn_info();

                    var checker = new PgnChecker();
                    checker.Visit(tree);

                    var pgn = checker.Pgn;
                    pgn.PgnView = match.Value;

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
