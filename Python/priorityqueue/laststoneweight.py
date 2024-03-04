from ast import List
import heapq


class Solution:
    def lastStoneWeight(self, stones:List[int]) ->int:
        stones = [-s for s in stones]
        heapq.heapify(stones) # linear time

        while len(stones)>1:
            first = heapq.heappop(stones)
            second = heapq.heappop(stones)
            if second > first: #since we negated everyting for max heap                
                heapq.heappush(stones, first-second)
        
        return 0 if len(stones)==0 else -stones[0]
            
