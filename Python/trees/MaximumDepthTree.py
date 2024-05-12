from trees.TreeNode import TreeNode


class Solution:
    def MaximumDepthOfTree(self, root:TreeNode):
        if not root:
            return 0
        return 1+max(self.MaximumDepthOfTree(root.left)+self.MaximumDepthOfTree(root.right))
