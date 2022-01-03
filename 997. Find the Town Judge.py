# In a town, there are n people labeled from 1 to n. There is a rumor that one of these people is secretly the town judge.
# If the town judge exists, then:
# The town judge trusts nobody.
# Everybody (except for the town judge) trusts the town judge.
# There is exactly one person that satisfies properties 1 and 2.
# You are given an array trust where trust[i] = [ai, bi] representing that the person labeled ai trusts the person labeled bi.
# Return the label of the town judge if the town judge exists and can be identified, or return -1 otherwise.

# 1 <= n <= 1000
# 0 <= trust.length <= 10^4
# trust[i].length == 2
# All the pairs of trust are unique.
# ai != bi
# 1 <= ai, bi <= n

from typing import List


class Solution:
    def findJudge(self, n: int, trust: List[List[int]]) -> int:
        trust_dict, trustor_dict = {}, {}
        for t in trust:
            trustor_dict[t[0]] = trustor_dict.get(t[0],0) + 1
            trust_dict[t[1]] = trust_dict.get(t[1],0) + 1
        result = -1
        for i in range(1,n+1):
            if trust_dict.get(i,0) == n-1 and trustor_dict.get(i,0) == 0:
                if result == -1:
                    result = i
                else:
                    return -1
        return result



solver = Solution()
print(solver.findJudge(2, [[1,2]])) # 2

print(solver.findJudge(3, [[1,3],[2,3]])) # 3

print(solver.findJudge(3, [[1,3],[2,3],[3,1]])) #-1
print(solver.findJudge(1, [])) #-1