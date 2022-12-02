using System.Linq;

namespace AdventOfCode
{
    [PuzzleDay(1)]
    public class Day1 : IPuzzleSolver
    {
        public int PartOne(string input) => input.Split("\n\n").Select(e => e.Split('\n').Select(int.Parse).Sum()).Max();
        public int PartTwo(string input) => input.Split("\n\n").Select(e => e.Split('\n').Select(int.Parse).Sum()).OrderByDescending(c => c).Take(3).Sum();
    }
}