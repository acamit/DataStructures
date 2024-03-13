class Solution:
    def CountBits(self, n): # time efficient as per leet code run
        res = [-1]*(n+1)
        res[0] = 0
        for i in range(1, n+1):
            cur = 0
            temp = i
            while i>0:
                cur += i%2
                i = i//2
                if res[i] != -1:
                    cur += res[i]
                    break
            res[temp] = cur
        return res
    
    def CountBitsNC(self, n): #memory efficient as per leet code run
        dp = [0] * (n+1)
        offset = 1

        for i in range(1, n+1):
            if offset * 2 == i:
                offset = i
            dp[i] = 1 + dp[i-offset]
        return dp
        