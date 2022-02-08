# There are n cities. Some of them are connected, while some are not. If city a is connected directly with city b, and city b is connected directly with city c, then city a is connected indirectly with city c.
# A province is a group of directly or indirectly connected cities and no other cities outside of the group.
# You are given an n x n matrix isConnected where isConnected[i][j] = 1 if the ith city and the jth city are directly connected, and isConnected[i][j] = 0 otherwise.
# Return the total number of provinces.

# 1 <= n <= 200
# n == isConnected.length
# n == isConnected[i].length
# isConnected[i][j] is 1 or 0.
# isConnected[i][i] == 1
# isConnected[i][j] == isConnected[j][i]

from typing import List

class Solution:
    def findCircleNum(self, isConnected: List[List[int]]) -> int:
        visited, queue, connected = [False for _ in range(len(isConnected))], [], 0
        for city in range(len(visited)):
            if not visited[city]:
                connected += 1
                queue.append(city)
                while len(queue)>0:
                    curr_city = queue.pop(0)
                    for possible_neig in range(len(isConnected)):
                        if possible_neig != curr_city and isConnected[curr_city][possible_neig] == 1 and not visited[possible_neig]:
                            visited[possible_neig] = True
                            queue.append(possible_neig)
        return connected

solver = Solution()
print(solver.findCircleNum([[1,1,0],[1,1,0],[0,0,1]])==2)
print(solver.findCircleNum([[1,0,0],[0,1,0],[0,0,1]])==3)