# maximum sum subarray of size K in a circular array

class Solution:
    def MaxSumSubarray(arr, k):
        n = len(arr)
        if n < k: # invalid case
            return
        Sum = 0
        start = 0
        end = k-1

        for i in range(k):
            Sum +=arr[i]
        
        ans = Sum

        for i in range(k, n+k):
            Sum+= arr[i%n] - arr[(i-k)%n]

            if Sum > ans:
                ans = Sum
                start =(i-k+1)%n
                end = i%n
        
        return (Sum, start, end)