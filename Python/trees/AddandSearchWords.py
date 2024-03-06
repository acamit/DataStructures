from trees.TrieNode import TrieNode


class WordDictionary:
    def __init__(self) -> None:
        self.root = TrieNode()

    def addWord(self, word):
        pcrawl = self.root
        length = len(word)
        for level in range(length):
            index = self._getIndex(word[level])
            if not pcrawl.children[index]:
                pcrawl.children[index] = TrieNode()
            pcrawl = pcrawl.children[index]
        pcrawl.isEndOfWord = True

    def search(self, word):
        def dfs(j, root, word):
            pcrawl = root
            length = len(word)
            for level in range(j, length):
                c = word[level]
                if c == '.':
                    for child in pcrawl.children:
                        if child is not None:
                            if dfs(level+1, child):
                                return True
                    return False
                else:
                    index = self._getIndex(c)
                    if not pcrawl.children[index]:
                        return False
                    else:
                        pcrawl = pcrawl.children[index]
            return pcrawl.isEndOfWord
        
        return dfs(0, self.root, word)

        


    def _getIndex(ch):
        return ord(ch)-ord('a')
        
