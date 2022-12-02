using System;
using System.IO;
using AdventOfCode;

public static class Program
{
    private static void Main(string[] args)
    {
        var day = args[0].Int();
        var input = File.ReadAllText($"Input/d{day}.txt").Trim();

        var partOneAnswer = IPuzzleSolver.GetSolver(day).PartOne(input);
        var partTwoAnswer = IPuzzleSolver.GetSolver(day).PartTwo(input);

        Console.WriteLine($"Answer for Day {day} Part One is {partOneAnswer}.");
        Console.WriteLine($"Answer for Day {day} Part Two is {partTwoAnswer}.");
    }
}