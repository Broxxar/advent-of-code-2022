using System;
using System.Runtime.InteropServices;

namespace AdventOfCode
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct int2
    {
        [FieldOffset(0)] private unsafe fixed int _data[2];
        [FieldOffset(0)] public int x;
        [FieldOffset(4)] public int y;

        public unsafe int this[int i]
        {
            get => _data[i];
            set => _data[i] = value;
        }

        public int2(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static int2 operator +(int2 a, int2 b)
        {

            return new int2(a.x + b.x, a.y + b.y);
        }

        public static int2 operator -(int2 a, int2 b)
        {
            return new int2(a.x - b.x, a.y - b.y);
        }

        public static int2 operator *(int2 a, int2 b)
        {
            return new int2(a.x * b.x, a.y * b.y);
        }

        public static int2 operator /(int2 a, int2 b)
        {
            return new int2(a.x / b.x, a.y / b.y);
        }

        public static bool operator ==(int2 a, int2 b)
        {
            return a.x == b.x && a.y == b.y;
        }

        public static bool operator !=(int2 a, int2 b)
        {
            return !(a == b);
        }
        
        public static int2 Max(int2 a, int2 b)
        {
            return new int2(Math.Max(a.x, b.x), Math.Max(a.y, b.y));
        }

        public static int2 Min(int2 a, int2 b)
        {
            return new int2(Math.Min(a.x, b.x), Math.Min(a.y, b.y));
        }

        public static int2 Sign(int2 p)
        {
            return new int2(Math.Sign(p.x), Math.Sign(p.y));
        }

        public static int2 Parse(string str, char separator = ',')
        {
            var s = str.Split(separator);
            return new int2(s[0].Int(), s[1].Int());
        }

        public bool Equals(int2 other)
        {
            return x == other.x && y == other.y;
        }

        public override bool Equals(object obj)
        {
            return obj is int2 other && Equals(other);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(x, y);
        }

        public override string ToString() => $"({x}, {y})";
    }
}