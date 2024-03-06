from trees.TrieNode import TrieNode


class Trie:
    def __init__(self) -> None:
        self.root = self.getNode()
    
    def getNode(self):
     
        # Returns new trie node (initialized to NULLs)
        return TrieNode()
    
    def _charToIndex(self, ch):
        return ord(ch) - ord('a')
    

    def insert(self, key):
        pCrawl = self.root

        length = len(key)
        for level in range(length):
            index = self._charToIndex(key[level])
            if not pCrawl.children[index]:
                pCrawl.children[index] = self.getNode()
            
            pCrawl = pCrawl.children[index]
        
        pCrawl.isEndOfWord = True

    def Search(self, key):
        length = len(key)
        pcrawl = self.root
        for level in range(length):
            index= self._charToIndex(key[level])
            if not pcrawl.children[index]:
                return False
            pcrawl = pcrawl.children[index]

        return pcrawl.isEndOfWord # if it is end of word, then key was formally inserted else it is just a prefix of another word. 