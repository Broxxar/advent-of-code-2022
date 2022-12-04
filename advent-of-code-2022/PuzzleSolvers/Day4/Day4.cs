using System.Linq;

namespace AdventOfCode.Day4
{
    [PuzzleDay(4)]
    public class Day4 : IPuzzleSolver
    {
        public int PartOne(string input)
        {
            return input
                .SplitF(s => s.Split(',').Arrayify(Range<int>.Parse))
                .Select(s => new {a = s[0], b = s[1]})
                .Count(p => p.a.Contains(p.b) || p.b.Contains(p.a));
        }

        public int PartTwo(string input)
        {
            return input
                .SplitF(s => s.Split(',').Arrayify(Range<int>.Parse))
                .Select(s => new {a = s[0], b = s[1]})
                .Count(p => p.a.Overlaps(p.b));
        }
    }
}