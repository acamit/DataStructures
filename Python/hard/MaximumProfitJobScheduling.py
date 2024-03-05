import bisect


class Solution:
    def jobScheduling(self, startTime, endTime, profit):
        intervals = sorted(zip(startTime, endTime, profit))
        cache = {}
        def dfs(i):
            if i == len(intervals):
                return 0
            if i in cache:
                return cache[i]
            # don't include
            res = dfs(i+1)
            j = bisect.bisect(intervals, (intervals[i][1], -1, -1)) # build in binary search for python
            # j = i+1
            # while j<len(intervals):
            #     if intervals[i][1] <= intervals[j][0]:
            #         break
            #     j+=1

            # include
            res = max(intervals[i][2]+ dfs(j), res)
            cache[i] = res

            return res

        return dfs(0)