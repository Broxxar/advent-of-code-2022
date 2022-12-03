# Day 3

Ranges! A C# feature I have not had enough opportunities to use came in clutch to split up those ruck sacks in part one. Their a staple of other languages like Python, but they only came to C# in 8.0 a few years ago so I've never messed with them much. Slicing up the ruck sack and `Intersect()`ing made finding the common item in either compartment a snap. Then it was just a bit of `char` arithmetic, sum things up, and we're all set!

Part Two was hard to do nicely without a local variable to cache the results of splitting the input, but otherwise the strategy is similar: split things up, intersect the strings, `char` arithmetic, and sum!

Was late to the party on this one, turns out 9PM on a Friday night is not my ideal time to be doing coding puzzles! Shame, because I felt pretty quick churning these out. Definitely feel my instincts for `char` shenanigans and cool tricks like array slicing are getting better. Until next time!