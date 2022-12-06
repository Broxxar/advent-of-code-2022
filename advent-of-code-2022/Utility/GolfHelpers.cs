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

        public static IEnumerable<T[]> Clump<T>(this IEnumerable<T> enumerable, int clumpSize)
        {
            return enumerable.Select((element, index) => new { element, index })
                .GroupBy(indexedElement => indexedElement.index / clumpSize)
                .Select(group => group.Select(t => t.element))
                .Select(group => group.ToArray());
        }

        public static IEnumerable<T> SplitF<T>(this string str, Func<string, T> functor, char separator = '\n')  => str.Split(separator).Select(functor);

        /// <summary>
        /// Combines the common pattern of splitting a string and applying a functor to process the resulting array of strings.
        /// </summary>
        public static IEnumerable<T> SplitF<T>(this string str, Func<string, T> functor, string separator) => str.Split(separator).Select(functor);

        /// <summary>
        ///  Combines Select and ToArray with a functor to quickly make arrays.
        /// </summary>
        public static TDst[] Arrayify<TSrc, TDst>(this IEnumerable<TSrc> enumerable, Func<TSrc, TDst> functor) => enumerable.Select(functor).ToArray();

        public static HashSet<T> Set<T>(this IEnumerable<T> enumerable) => enumerable.ToHashSet();

        public static IEnumerable<int> Itr(this Range range) => Enumerable.Range(range.Start.Value, range.End.Value);
    }
}