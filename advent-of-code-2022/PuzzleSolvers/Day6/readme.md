# Day 6
A welcome return to form after the bungling of Day 5. Today's puzzle can be expressed quite nicely with out-of-box LINQ and array slicing.

Iterate the indices of the strings, taking the characters from i to i+4. For each character, count the number of times it occurs in the current group of 4. If all only characters only occur once, the current index (plus 4!) is the start-of-message marker.

Part Two was literally just quickly prepending a 1 to a few hard coded 4s to make them 14s!

## Update

Code golfed this one a bit. After seeing some other folks use of a set in solutions for this day, I wanted to revisit mine. Massively simplifies things! I also took the decided to make a more concise extension method for `ToHashset<T>()` just called `Set<T>()` for increased brevity.

Then I got bother by the overly verbose `Enumerable.Range`, and the fact that it doesn't actually allow me to use the fancy new `System.Range` specifier and syntax. Extension methods to the rescue again! `Itr(this Range range)` allows me to use range syntax and quickly convert to an enumerable of `int`s! This is really slick. In C# 9, you can even have an extenstion GetEnumerator. Can't quite get all the way to an implicit cast from a range to `IEnumerable<int>` though. That would be amazing for golfing.

Some of my other golfing helpers have not proved to be super useful so far, but _this time_ I have a really good feeling these two new ones will see usage! Maybe...