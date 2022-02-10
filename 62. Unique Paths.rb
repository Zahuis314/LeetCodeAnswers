# There is a robot on an m x n grid. The robot is initially located at the top-left corner (i.e., grid[0][0]). The robot tries to move to the bottom-right corner (i.e., grid[m - 1][n - 1]). The robot can only move either down or right at any point in time.
# Given the two integers m and n, return the number of possible unique paths that the robot can take to reach the bottom-right corner.
# The test cases are generated so that the answer will be less than or equal to 2 * 109.

# 1 <= m, n <= 100

# @param {Integer} m
# @param {Integer} n
# @return {Integer}
def unique_paths(m, n)
    dp = Array.new(m,Array.new(n))
    dp.each_index do |i|
        dp[i].each_index do |j|
            if(i*j==0)
                dp[i][j]=1
            elsif
                dp[i][j]=dp[i][j-1]+dp[i-1][j]
            end
        end
    end
    return dp[m-1][n-1]
end

p unique_paths(3,7)==28
p unique_paths(3,2)==3