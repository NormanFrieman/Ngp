using Ngp.Generated;

namespace Ngp
{
    internal class PgnChecker : PgnBaseVisitor<int>
    {
        public Pgn Pgn = new();

        override public int VisitInfo(PgnParser.InfoContext context)
        {
            var attr = context.attrs().GetText();
            var isDate = context.attrs().DATE() != null || context.attrs().UTCDATE() != null;

            var value = context.STRING_VALUE().GetText().Replace("\"", "");

            typeof(Pgn)
                .GetProperty(!isDate
                    ? attr
                    : "Date")!
                .SetValue(Pgn, !isDate
                    ? value
                    : value
                        .Replace(".", "-")
                );

            return 0;
        }
    }
}
