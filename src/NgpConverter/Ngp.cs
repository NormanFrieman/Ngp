using NgpConverter.Models;

namespace NgpConverter
{
    public static class Ngp
    {
        public static IEnumerable<Pgn> Convert(string pgnStr)
        {
            return PgnCompiler.Compile(pgnStr);
        }
    }
}
