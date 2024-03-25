class Solution:
    def MaximumProductSubarray(self, nums):
        res = max(nums)
        curMin, curMax = 1, 1

        for n in nums:
            if n == 0:
                curMin, curMax = 1, 1
                continue
            tmp = curMax * n # needed to prevent override on line 11
            curMax = max(tmp, curMin * n, n)  # [-1, 8] n is required for such cases
            curMin = min(tmp, curMin * n, n)  # [-1, -8]

            res = max(res, curMax)
            
        return res