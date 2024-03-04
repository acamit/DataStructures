from math import ceil


class Solution:
    def lastStoneWeight(self, stones):
        stoneSum = sum(stones)
        target = ceil(stoneSum/2)
        dp = {}

        def dfs(i, total):
            if total>=target or i == len(stones):
                return abs(total-(stoneSum-total))

            if (i, total) in dp:
                return dp[(i, total)]
            
            dp[(i, total)]= min(dfs(i+1, total), dfs(i, total+stones[i]))
            return dp[(i, total)]
        
        return dfs(0, 0)