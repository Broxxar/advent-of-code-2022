using System;

namespace AdventOfCode
{
    public struct Range<T> where T : struct, IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable
    {
        private readonly T _start;
        private readonly T _end;

        public T Start => _start;
        public T End => _end;

        public Range(T start, T end)
        {
            _start = start;
            _end = end;
        }

        public bool Contains(T value) => _start.CompareTo(value) <= 0 && _end.CompareTo(value) >= 0;

        public bool Contains(Range<T> range) => Contains(range.Start) && Contains(range.End);

        public bool Overlaps(Range<T> range) => Contains(range.Start) || Contains(range.End) || range.Contains(Start) || range.Contains(End);

        // TODO: Make versions for other numerics? Puzzling seems mostly int based for now, so whatever.
        public static Range<int> Parse(string str)
        {
            var s = str.Split('-');
            return new Range<int>(s[0].Int(), s[1].Int());
        }

        public static Range<int> Parse(string str, char separator)
        {
            var s = str.Split(separator);
            return new Range<int>(s[0].Int(), s[1].Int());
        }

        public override string ToString() => $"[{Start}..{End}]";
    }
}