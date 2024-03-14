class Solution:
    def reverseBits(self, n:int)->int:
        res = 0 
        for i in range(32):
            # get ith bit. Move the i th bit to first position and & it with 1 so that we only get that 1 bit. 
            bit = (n >> i) & 1
            # move that bit to the required location by doing 31-i move. and then or it with rest to get it in right place
            res = res | (bit << 31 -i)
