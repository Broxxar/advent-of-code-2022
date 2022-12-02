using System;

namespace AdventOfCode
{
    public class PuzzleDayAttribute : Attribute
    {
        public readonly int Day;

        public PuzzleDayAttribute(int day)
        {
            Day = day;
        }
    }
}