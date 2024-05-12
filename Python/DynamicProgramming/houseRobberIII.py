class Solution:
    def HouseRoberIII(self,root):
        #[withRoot, withoutRoot]
        def dfs(root):
            if not root:
                return [0,0]
            
            leftPair = dfs(root.left)
            rightPair = dfs(root.right)

            withRoot = root.val + leftPair[1] + rightPair[1]
            # max without current root
            withoutRoot = max(leftPair) + max(rightPair)
            
            return [withRoot, withoutRoot]

        return max(dfs(root))
       