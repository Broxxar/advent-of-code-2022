using System.Linq;

namespace AdventOfCode.Day6
{
    [PuzzleDay(6)]
    public class Day6 : IPuzzleSolver
    {
        public int PartOne(string input) => (..(input.Length - 4)).Itr().First(i => input[i..(i + 4)].Set().Count == 4) + 4;
        public int PartTwo(string input) => (..(input.Length - 4)).Itr().First(i => input[i..(i + 14)].Set().Count == 14) + 14;
    }
}