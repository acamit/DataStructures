from typing import List


class Solution:
    def merge(self, intervals:List[list[int]])-> List[List[int]]:
        intervals.sort(key=lambda i:i[0])
        output = [intervals[0]]

        for start, end in intervals[1:]:
            if output[-1][1]>=start:
                newInterval = [output[-1][0], max(output[-1][1],end)]
                output.pop() # default to last index
                output.append(newInterval)
            else:
                output.append([start, end])
        
        return output