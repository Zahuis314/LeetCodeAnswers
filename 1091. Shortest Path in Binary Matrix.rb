# Given an n x n binary matrix grid, return the length of the shortest clear path in the matrix. If there is no clear path, return -1.
# A clear path in a binary matrix is a path from the top-left cell (i.e., (0, 0)) to the bottom-right cell (i.e., (n - 1, n - 1)) such that:
# All the visited cells of the path are 0.
# All the adjacent cells of the path are 8-directionally connected (i.e., they are different and they share an edge or a corner).
# The length of a clear path is the number of visited cells of this path.

# n == grid.length
# n == grid[i].length
# 1 <= n <= 100
# grid[i][j] is 0 or 1

# @param {Integer[][]} grid
# @return {Integer}
def shortest_path_binary_matrix(grid)
    return -1 if grid[-1][-1]==1 or grid[0][0]==1
    m, n = grid.length, grid[0].length
    queue = [[0,0]]
    visited = Array.new(m){Array.new(n,false)}
    visited[0][0]=true
    dir_array = [[-1,-1],[-1,0],[-1,1],
                 [ 0,-1],       [ 0,1],
                 [ 1,-1],[ 1,0],[ 1,1]]
    length = 1
    until queue.empty?
        queue.length.times do
            x, y = queue.shift
            return length if x==m-1 and y==n-1
            for dir in dir_array do
                new_x, new_y = x+dir[0], y+dir[1]
                if(new_x>=0 and new_y>=0 and new_x<m and new_y<n and !visited[new_x][new_y] and grid[new_x][new_y]==0)
                    visited[new_x][new_y] = true
                    queue.push([new_x, new_y])
                end
            end
        end
        length += 1
    end
    return -1
end

p shortest_path_binary_matrix([[0,1],[1,0]])==2                # 2
p shortest_path_binary_matrix([[0,0,0],[1,1,0],[1,1,0]])==4    # 4
p shortest_path_binary_matrix([[1,0,0],[1,1,0],[1,1,0]])==-1    # -1
p shortest_path_binary_matrix([[1]])==-1    # -1
p shortest_path_binary_matrix([[0]])==1    # 1
