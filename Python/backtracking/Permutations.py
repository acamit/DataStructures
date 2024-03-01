"""
    Return all possible permutations. 
"""
results = []
def permutations(nums):
    
    if len(nums) ==1:
        return [nums[:]] #return a list of lists
    
    for i in range(len(nums)):
        n = nums.pop(0)
        perms = permutations(nums)
        for perm in perms:
            perm.append(n)
        
        nums.append(n)
        results.extend(perms)