using System;
using System.Linq;
using System.Reflection;

namespace AdventOfCode
{
    public interface IPuzzleSolver
    {
        int PartOne(string input);
        int PartTwo(string input);

        public static IPuzzleSolver GetSolver(int day)
        {
            var solverTypeInfo = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(asm => asm.DefinedTypes)
                .FirstOrDefault(typeInfo =>
                {
                    var tag = typeInfo.GetCustomAttribute<PuzzleDayAttribute>();
                    return tag != null && tag.Day == day;
                });

            if (solverTypeInfo == null)
            {
                throw new Exception($"No puzzle solver defined for day {day}.");
            }

            return (IPuzzleSolver)Activator.CreateInstance(solverTypeInfo.AsType());
        }
    }
}