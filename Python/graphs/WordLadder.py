from collections import defaultdict, deque
from typing import List


class Solution:
    def ladder_length(self, begin_word:str, end_word:str, word_list:List[str])->int:
        if end_word not in word_list:
            return 0
        
        nei = defaultdict(list)
        word_list.append(begin_word)
        
        for word in word_list:
            for j in range(len(word)):
                pattern = word[:j]+"*"+word[j+1:]
                nei[pattern].append(word)

        visit = set([begin_word])
        q = deque([begin_word])
        res = 1
        while q:
            for i in range(len(q)):
                word = q.popleft()
                if word == end_word:
                    return res
                for j in range(len(word)):
                    pattern = word[:j]+"*"+word[j+1:]
                    for neiWord in nei[pattern]:
                        if neiWord not in visit:
                            visit.add(neiWord)
                            q.append(neiWord)
        return 0