using System.Linq;

namespace AdventOfCode.Day6
{
    [PuzzleDay(6)]
    public class Day6 : IPuzzleSolver
    {
        public int PartOne(string input) => Enumerable.Range(0, input.Length - 4).First(i => input[i..(i + 4)].Select(c => input[i..(i + 4)].Count(c2 => c == c2)).All(n => n == 1)) + 4;
        public int PartTwo(string input) => Enumerable.Range(0, input.Length - 14).First(i => input[i..(i + 14)].Select(c => input[i..(i + 14)].Count(c2 => c == c2)).All(n => n == 1)) + 14;
    }
}