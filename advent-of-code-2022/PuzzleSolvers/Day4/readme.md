# Day 4
Bleah. Today I Learned™: `Enumerable.Range()`'s arguments are `start` and `count`. Really thought the second argument was `end` which completely through me off.

During Part One, I attempted to use this and produced an incorrect answer. I was perplexed, but I quickly pivoted and wrote the range check as a boolean of inequalities which worked out fine.

Then again in Part Two, my instinct was again "If I can just express this as a range and check if any value is contained I'm done..." I ended up checking the [MSDN Reference Page for Enumerable.Range](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.range?view=net-7.0) and I'm glad I did. My solve would have been much cleaner and quicker to produce had it not been for this misunderstanding. I actually could have used nearly identical code to Part One, only having to switch an `All` clause for an `Any`.

Dang. I might poke around for a better way to express ranges of numeric types. If it had it's own string parse method, I could clean up this solver even more. Hmm...

## Update

So I got carried away.

I wrote a `Range<T>` class and a `string Parse` for `Range<int>` that trivializes today's puzzle. I also wrote added some extension methods to do some more of the common things puzzles require. For example, basically every puzzle starts with splitting the input by `\n` and applying some transformation to the resulting array of strings (which may in turn be more string splitting, parsing types, creating an anonymous objects, etc). My new `SplitF` method combines some of this functionality. I also find it common to take an enumerable of some data, transform it, and return the result as an Array for subsequent queries to index into. `Arrayify` does this.

I'm definitely skewing further away from basic LINQ and into weird puzzle-specific C# (though perhaps still idiomatic).

Some of these tools overlap in functionality. I can already see how I could have chained together `SplitF`s and used the vanilla `ToArray` to express the same thing as the `Arrayify` does in my updated solution to Day 4. Hopefully having more stuff in the tool box ends up helping though, and not just adding confusion in the future... 😅