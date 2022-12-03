using System.Linq;

namespace AdventOfCode
{
    [PuzzleDay(3)]
    public class Day3 : IPuzzleSolver
    {
        public int PartOne(string input)
        {
            return input.Split('\n')
                .Select(r => r[..(r.Length / 2)].Intersect(r[(r.Length / 2)..]).First())
                .Select(i => i > 96 ? i - 96 : i - 38)
                .Sum();
        }

        public int PartTwo(string input)
        {
            return input.Split('\n')
                .Clump(3)
                .Select(g => g[0].Intersect(g[1]).Intersect(g[2]).First())
                .Select(i => i > 96 ? i - 96 : i - 38)
                .Sum();
        }
    }
}