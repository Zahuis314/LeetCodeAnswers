# Given an m x n binary matrix mat, return the distance of the nearest 0 for each cell.
# The distance between two adjacent cells is 1.

# m == mat.length
# n == mat[i].length
# 1 <= m, n <= 10^4
# 1 <= m * n <= 10^4
# mat[i][j] is either 0 or 1.
# There is at least one 0 in mat.

# @param {Integer[][]} mat
# @return {Integer[][]}
def update_matrix(mat)
    (0...mat.length).each do |i|
        (0...mat[i].length).each do |j|
            next if mat[i][j] == 0
            mat[i][j] = Float::INFINITY
            mat[i][j] = [mat[i][j], mat[i-1][j]+1].min if i>0
            mat[i][j] = [mat[i][j], mat[i][j-1]+1].min if j>0
        end
    end
    (0...mat.length).reverse_each do |i|
        (0...mat[i].length).reverse_each do |j|
            next if mat[i][j] == 0
            mat[i][j] = [mat[i][j], mat[i+1][j]+1].min if i<mat.length-1
            mat[i][j] = [mat[i][j], mat[i][j+1]+1].min if j<mat[i].length-1
        end
    end
    mat
end

result1 = update_matrix([[0,0,0],[0,1,0],[0,0,0]]) #[[0,0,0],[0,1,0],[0,0,0]]
result2 = update_matrix([[0,0,0],[0,1,0],[1,1,1]]) #[[0,0,0],[0,1,0],[1,2,1]]
result3 = update_matrix([
    [0,1,0,1,1],        #[0,1,0,1,2]
    [1,1,0,0,1],        #[1,1,0,0,1]
    [0,0,0,1,0],        #[0,0,0,1,0]
    [1,0,1,1,1],        #[1,0,1,1,1]
    [1,0,0,0,1]])       #[1,0,0,0,1]
p 1