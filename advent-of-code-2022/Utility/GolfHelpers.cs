using System;
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

        public static int2 Int2(this string str, char separator = ',') => int2.Parse(str, separator);

        public static string Replace(this string str, params (string oldValue, string newValue)[] replacements)
        {
            foreach (var replacement in replacements)
            {
                str = str.Replace(replacement.oldValue, replacement.@newValue);
            }

            return str;
        }

        public static bool Bool(this string str) => bool.Parse(str);

        public static IEnumerable<T> Insert<T>(this IEnumerable<T> enumerable, int index, T value)
        {
            var list = enumerable.ToList();
            list.Insert(index, value);
            return list;
        }

        public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> functor)
        {
            foreach (var element in enumerable)
            {
                functor(element);
            }
        }
    }
}