class Solution:
    def MissingNumber(self, nums):
        res = len(nums)
        for i in range(len(nums)):
            res = res+ i - nums[i]    
        return res