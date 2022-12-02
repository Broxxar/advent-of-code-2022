using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode
{
    /// <summary>
    /// Extension methods which may help express some common operations in LINQ in fewer characters.
    /// </summary>
    public static class GolfHelpers
    {
        public static int Int(this string str) => int.Parse(str);

        public static bool Bool(this string str) => bool.Parse(str);

        public static IEnumerable<T> Insert<T>(this IEnumerable<T> enumerable, int index, T value)
        {
            var list = enumerable.ToList();
            list.Insert(index, value);
            return list;
        }
    }
}