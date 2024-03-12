class Solution:
    def NumbersWithGivenSum(self, nums, target):
        cache = {}

        for i in range(nums):
            dif = target - nums[i]
            
            if dif in cache:
                return [cache[target - nums[i]], i]

            cache[nums[i]] = i

        return [0, 0]