# Day 6
A welcome return to form after the bungling of Day 5. Today's puzzle can be expressed quite nicely with out-of-box LINQ and array slicing.

Iterate the indices of the strings, taking the characters from i to i+4. For each character, count the number of times it occurs in the current group of 4. If all only characters only occur once, the current index (plus 4!) is the start-of-message marker.

Part Two was literally just quickly prepending a 1 to a few hard coded 4s to make them 14s!