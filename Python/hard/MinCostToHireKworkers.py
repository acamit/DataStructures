import heapq
from typing import List


class Solution:
    # O(nlogn + nlogk)
    # space = o(n)
    def hireKWorkers(self, quality:List[int], wage:List[int], k:int)-> float:
        res = float("inf")
        pairs = [] #(ratio, quaity)

        for i in range(len(quality)):
            pairs.append((wage[i]/quality[i], quality[i]))

        pairs.sort(key=lambda p:p[0])
        
        maxHeap = [] #qualities

        total_quality = 0

        for rate, q in pairs:
            heapq.heappush(maxHeap, -q) # - to change min heap to max heap
            total_quality += q

            if len(maxHeap) > k :
                total_quality += heapq.heappop(maxHeap)
                
            if len(maxHeap) == k:
                res = min(res, total_quality * rate)
        return res