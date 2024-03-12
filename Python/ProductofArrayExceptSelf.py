class Solution:
    def ProductArrayExceptSelf(self, nums):
        l = len(nums)
        prefix = [-1]* l
        postfix = [-1]* l
        output = [-1]* l
        
        prefix[0] = nums[0]
        postfix[l] = nums[l -1]

        for i in range(1, l):
            prefix[i] = nums[i-1]*prefix[i-1]

        for i in range(l-2, -1, -1):
            postfix[i]= nums[i+1]*postfix[i+1]
        
        for i in range(l):
            output[i] = prefix[i] * postfix[i]

        return output
    
    #optimizeforspace
    def ProductArrayExceptSelfOptimized(self, nums):
        l = len(nums)
        output = [1]* l
        
        output[0] = 1

        for i in range(1, l):
            output[i] = nums[i-1]*output[i-1]

        post = 1
        for i in range(l-1, -1, -1):
            output[i] = output[i] * post
            post = nums[i]*post
        
        return output
            
        
