using NgpConverter.Generated;
using NgpConverter.Models;

namespace NgpConverter
{
    public class PgnChecker : PgnBaseVisitor<int>
    {
        public Pgn Pgn = new();

        override public int VisitInfo(PgnParser.InfoContext context)
        {
            var attr = context.attrs().GetText();
            var value = context.STRING_VALUE().GetText();

            typeof(Pgn).GetProperty(attr)!.SetValue(Pgn, value);

            return 0;
        }
    }
}
