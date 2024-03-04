"""
    Minimum number of intervals to remove so that remaining ones are non-overlapping
"""
from typing import List


class Solution:
    def NonOverlapping(self, intervals:List[list[int]])-> List[List[int]]:
        intervals.sort()
        removed = 0
        prevEnd = intervals[0][1]
        for start, end in intervals[1:]:
            if start<prevEnd:
                removed+=1
            
            prevEnd = min(end, prevEnd) # remove the one that ends last. keeping the one that ends first. the sooner it ends. lesser the chance of it overlapping with next ones.
        return removed

        