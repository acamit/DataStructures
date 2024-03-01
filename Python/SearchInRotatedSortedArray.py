from typing import List


class Solution:
    def Search(self, nums : List[int], target: int)-> int:
        l = 0
        r = len(nums)
        

        while l<=r:
            mid = (l+r)//2
            if nums[mid] == target:
                return mid
            

        # left sorted section 
            if nums[mid] >= nums[l]:
                if target> nums[mid] or target<nums[l]:
                    l = mid+1
                else:
                    r = mid-1
            else: # right sorted section
                if target < nums[mid] or target> nums[r]:
                    r = mid-1
                else:
                    l = mid + 1
        return -1
    