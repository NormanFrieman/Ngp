using NgpCompiler.Generated;
using NgpCompiler.Models;

namespace NgpCompiler
{
    public class PgnChecker : PgnBaseVisitor<object>
    {
        public Pgn Pgn = new();

        override public object VisitInfo(PgnParser.InfoContext context)
        {
            var attr = context.attrs().GetText();
            var value = context.STRING_VALUE().GetText();

            typeof(Pgn).GetProperty(attr).SetValue(Pgn, value);

            return null;
        }
    }
}
