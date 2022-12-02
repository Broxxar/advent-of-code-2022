using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode
{
    [PuzzleDay(2)]
    public class Day2 : IPuzzleSolver
    {
        private Dictionary<string, int> p1 = new Dictionary<string, int>
        {
            { "A X", 1 + 3 },
            { "A Y", 2 + 6 },
            { "A Z", 3 + 0 },
            { "B X", 1 + 0 },
            { "B Y", 2 + 3 },
            { "B Z", 3 + 6 },
            { "C X", 1 + 6 },
            { "C Y", 2 + 0 },
            { "C Z", 3 + 3 }
        };

        private Dictionary<string, int> p2 = new Dictionary<string, int>
        {
            { "A X", 0 + 3 },
            { "A Y", 3 + 1 },
            { "A Z", 6 + 2 },
            { "B X", 0 + 1 },
            { "B Y", 3 + 2 },
            { "B Z", 6 + 3 },
            { "C X", 0 + 2 },
            { "C Y", 3 + 3 },
            { "C Z", 6 + 1 }
        };

        public int PartOne(string input) => input.Split('\n').Select(l => p1[l]).Sum();
        public int PartTwo(string input) => input.Split('\n').Select(l => p2[l]).Sum();
    }
}