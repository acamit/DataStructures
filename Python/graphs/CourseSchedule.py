class Solution:
    def CourseSchedule(self, numCourses, preRequisites):
        preMap = { i:[] for i in range(numCourses)}

        for crs, pre in preRequisites:
            preMap[crs].append(pre)
        
        visitSet = set()

        def dfs(crs):
            if crs in visitSet:
                return False # loop detected

            if preMap[crs] == []:
                return True # no prerequs
            
            visitSet.add(crs)
            for pre in preMap[crs]:
                if not dfs(pre):
                    return False
                
            visitSet.remove(crs)
            preMap[crs] = []
        
        for crs in range(numCourses):
            if not dfs(crs):
                return False
        return True

            
