# You are given a list of songs where the ith song has a duration of time[i] seconds.
# Return the number of pairs of songs for which their total duration in seconds is divisible by 60. Formally, we want the number of indices i, j such that i < j with (time[i] + time[j]) % 60 == 0.

# 1 <= time.length <= 6 * 10^4
# 1 <= time[i] <= 500

from typing import List


class Solution:
    def numPairsDivisibleBy60(self, time: List[int]) -> int:
        remain = {}
        for song in time:
            current = remain.get(song%60)
            if current:
                remain[song%60] += 1
            else:
                remain[song%60] = 1
        # (math.factorial(n))/2*math.factorial(n-2)
        remain0, remainhalf = remain.pop(0,0), remain.pop(30,0)
        sum = (remain0 * (remain0-1))//2
        sum += (remainhalf * (remainhalf-1))//2
        while len(remain) > 0:
            key, value = remain.popitem()
            complement = remain.pop(60-key,0)
            sum += value * complement
        return sum
solver = Solution()
result = solver.numPairsDivisibleBy60([30,20,150,100,40]) #3
result = solver.numPairsDivisibleBy60([60,60,60]) #3
