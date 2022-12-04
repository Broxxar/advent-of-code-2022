# Day 4
Bleah. Today I Learned™: `Enumerable.Range()`'s arguments are `start` and `count`. Really thought the second argument was `end` which completely through me off.

During Part One, I attempted to use this and produced an incorrect answer. I was perplexed, but I quickly pivoted and wrote the range check as a boolean of inequalities which worked out fine.

Then again in Part Two, my instinct was again "If I can just express this as a range and check if any value is contained I'm done..." I ended up checking the [MSDN Reference Page for Enumerable.Range](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.range?view=net-7.0) and I'm glad I did. My solve would have been much cleaner and quicker to produce had it not been for this misunderstanding. I actually could have used nearly identical code to Part One, only having to switch an `All` clause for an `Any`.

Dang. I might poke around for a better way to express ranges of numeric types. If it had it's own string parse method, I could clean up this solver even more. Hmm...