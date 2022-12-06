using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Day5
{
    [PuzzleDay(5)]
    public class Day5 : IPuzzleSolver
    {
        public int PartOne(string input)
        {
            var s = input.Split('\n');
            var stacks = Enumerable.Range(0, 9).Select(i => new {stack = new Stack<char>(), r = i * 4 + 1}).ToArray();

            s.Take(8)
                .Reverse()
                .ForEach(l => stacks.ForEach(st =>
                {
                    if (l[st.r] != ' ')
                    {
                        st.stack.Push(l[st.r]);
                    }
                }));

            s.Skip(10)
                .Select(l => l.Replace("move ", "").Replace(" from ", ",").Replace(" to ", ","))
                .Select(l => new {m = l.Split(',')[0].Int(), f = l.Split(',')[1].Int(), t = l.Split(',')[2].Int()})
                .ForEach(op => Enumerable.Range(0, op.m).ForEach(_ => stacks[op.t - 1].stack.Push(stacks[op.f - 1].stack.Pop())));

            foreach (var stack in stacks)
            {
                Console.Write(stack.stack.Pop());
            }

            Console.WriteLine();

            return 0;
        }

        public int PartTwo(string input)
        {
            var s = input.Split('\n');
            var stacks = Enumerable.Range(0, 9).Select(i => new {stack = new Stack<char>(), r = i * 4 + 1}).ToArray();

            s.Take(8)
                .Reverse()
                .ForEach(l => stacks.ForEach(st =>
                {
                    if (l[st.r] != ' ')
                    {
                        st.stack.Push(l[st.r]);
                    }
                }));

            s.Skip(10)
                .Select(l => l.Replace("move ", "").Replace(" from ", ",").Replace(" to ", ","))
                .Select(l => new {m = l.Split(',')[0].Int(), f = l.Split(',')[1].Int(), t = l.Split(',')[2].Int()})
                .ForEach(op => Enumerable.Range(0, op.m).Arrayify(_ => stacks[op.f - 1].stack.Pop()).Reverse().ForEach(c => stacks[op.t - 1].stack.Push(c)));

            foreach (var stack in stacks)
            {
                Console.Write(stack.stack.Pop());
            }

            Console.WriteLine();

            return 0;
        }
    }
}