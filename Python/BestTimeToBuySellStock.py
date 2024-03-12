class Solution:
    def bestTimetoBuySelf(self, prices):
        l = 0
        r = 1

        maxSoFar = 0       
        
        length = len(prices)

        while r<length:
            profit = prices[r] -prices[l]
            if profit > 0:
                maxSoFar = max(profit, maxSoFar)
            else:
                l = r
            r+=1
        return maxSoFar