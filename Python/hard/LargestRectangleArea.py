from typing import List

class Solution:
    def largestRectangleArea(self, heights: List[int])-> int:
        maxArea = 0
        stack = [] # pair : (index, height)

        for i, h in enumerate(heights):
            start = i
            while stack and stack[-1][1]> h: # if height of last element on stack is greater than current element
                index, height = stack.pop()
                maxArea = max(maxArea, height*(i-index))
                start = index
            stack.append((start, h))
        
        for i, h in stack:
            maxArea = max(maxArea, h*(len(heights)-i))
        return maxArea