class Solution:
    def MaxWaterTank(self, nums):
        max_area = 0
        l, r = 0, len(nums) - 1
        while l < r:
            cur_area = (r-l)*min(nums[l], r)
            max_area = max(max_area, cur_area)

            if nums[l]<nums[r]:
                l+=1
            else:
                r-=1
        return max_area
