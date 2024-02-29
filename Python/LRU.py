class LRUCache:
    def __init__(self, n) -> None:
        self.csize = n
        self.dq = []
        self.ma = {}

    
    def refer(self, x):
        if x not in self.ma.keys():
            if len(self.dq) == self.csize:

                # get the last element from queue
                last = self.dq[-1]

                # remove from the queue
                ele = self.dq.pop()

                # delete from the hash map
                del self.ma[last]
        else:
            del self.dq[self.ma[x]]
        
        self.dq.insert(0, x)
        self.ma[x] = 0