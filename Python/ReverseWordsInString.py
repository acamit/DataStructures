class Solution:
    def reverseString(self, s:str):
        s = list(s)
        l = 0
        r = 0
        sl = len(str)
        for r in range(sl):
            if s[r] == " " or r == sl-1:
                temp_l, temp_r = l, r-1
                if r == sl-1:
                    temp_r = r
                
                while temp_l<=temp_r:
                    s[temp_l], s[temp_r] = s[temp_r], s[temp_l]
                    temp_l+=1
                    temp_r+=1
                    
                l = r+1
        return "".join(s)