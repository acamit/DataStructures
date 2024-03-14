class Solution:
    def ClimbingStairs(self, n):
        cache = {}
        def dfs(i, res):
            if i in cache:
                return res+cache[i]           
            if i <= 1:
                return res+1
            res = dfs(i-1, res)
            res = dfs(i-2, res)
            cache[i] = res
            return res        
        return dfs(n, 0)

    # better time and space both
    def ClimbingStairsDP(self, n):
        one, two = 1, 1 
        for i in range(n-1):
            temp = one
            one = one + two
            two = temp
        
        return one