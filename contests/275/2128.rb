# An n x n matrix is valid if every row and every column contains all the integers from 1 to n (inclusive).
# Given an n x n integer matrix matrix, return true if the matrix is valid. Otherwise, return false.

# n == matrix.length == matrix[i].length
# 1 <= n <= 100
# 1 <= matrix[i][j] <= n

# @param {Integer[][]} matrix
# @return {Boolean}
def check_valid(matrix)
    checker = { c: Array.new(matrix.length) {{}}, r: Array.new(matrix.length) {{}} }
    (0...matrix.length).each do |i|
        (0...matrix.length).each do |j|
            if checker[:r][i].member?(matrix[i][j])
                return false
            end
            checker[:r][i][matrix[i][j]] = true

            if checker[:c][j].member?(matrix[i][j])
                return false
            end
            checker[:c][j][matrix[i][j]] = true
        end
    end
    return true
end

p check_valid([[1,1,1],[1,2,3],[1,2,3]])==false
p check_valid([[1,2,3],[3,1,2],[2,3,1]])==true