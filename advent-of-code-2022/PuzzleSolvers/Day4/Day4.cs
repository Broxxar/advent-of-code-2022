using System.Linq;

namespace AdventOfCode.Day4
{
    [PuzzleDay(4)]
    public class Day4 : IPuzzleSolver
    {
        public int PartOne(string input)
        {
            return input
                .Split('\n')
                .SelectMany(l => l.Split(','))
                .Select(e => e.Int2('-'))
                .Clump(2)
                .Count(p => p[0].x <= p[1].x && p[0].y >= p[1].y || p[1].x <= p[0].x && p[1].y >= p[0].y);
        }

        public int PartTwo(string input)
        {
            return input
                .Split('\n')
                .SelectMany(l => l.Split(','))
                .Select(e => e.Int2('-'))
                .Clump(2)
                .Count(p => Enumerable.Range(p[0].x, p[0].y - p[0].x + 1).Any(i => Enumerable.Range(p[1].x, p[1].y - p[1].x + 1).Contains(i)));
        }
    }
}