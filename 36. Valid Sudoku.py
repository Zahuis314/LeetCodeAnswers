# Determine if a 9 x 9 Sudoku board is valid. Only the filled cells need to be validated according to the following rules:
# Each row must contain the digits 1-9 without repetition.
# Each column must contain the digits 1-9 without repetition.
# Each of the nine 3 x 3 sub-boxes of the grid must contain the digits 1-9 without repetition.
# Note:
# A Sudoku board (partially filled) could be valid but is not necessarily solvable.
# Only the filled cells need to be validated according to the mentioned rules.

# board.length == 9
# board[i].length == 9
# board[i][j] is a digit 1-9 or '.'.

from typing import List

class Solution:
    def isValidSudoku(self, board: List[List[str]]) -> bool:
        def invalid_check(dict_key, dict_value, i,j):
            key = checker[dict_key].get(dict_value)
            if not key:
                checker[dict_key][dict_value] = {}
                key = checker[dict_key][dict_value]
            if board[i][j] in key:
                return True
            else:
                key[board[i][j]] = True
            return False
        checker = {"c": {}, "r": {}, "s": {}}
        params = [
            ["c", lambda x,_: x],
            ["r", lambda _,y: y],
            ["s", lambda x,y: (x//3)*3+(y//3)]]
        for i in range(9):
            for j in range(9):
                if board[i][j] != ".":
                    for param in params:
                        if invalid_check(param[0],param[1](i,j),i,j):
                            return False
        return True


solver = Solution()

test1 = [["5","3",".",  ".","7",".",  ".",".","."]
        ,["6",".",".",  "1","9","5",  ".",".","."]
        ,[".","9","8",  ".",".",".",  ".","6","."]

        ,["8",".",".",  ".","6",".",  ".",".","3"]
        ,["4",".",".",  "8",".","3",  ".",".","1"]
        ,["7",".",".",  ".","2",".",  ".",".","6"]

        ,[".","6",".",  ".",".",".",  "2","8","."]
        ,[".",".",".",  "4","1","9",  ".",".","5"]
        ,[".",".",".",  ".","8",".",  ".","7","9"]]


test2 = [["8","3",".",  ".","7",".",  ".",".","."]
        ,["6",".",".",  "1","9","5",  ".",".","."]
        ,[".","9","8",  ".",".",".",  ".","6","."]

        ,["8",".",".",  ".","6",".",  ".",".","3"]
        ,["4",".",".",  "8",".","3",  ".",".","1"]
        ,["7",".",".",  ".","2",".",  ".",".","6"]

        ,[".","6",".",  ".",".",".",  "2","8","."]
        ,[".",".",".",  "4","1","9",  ".",".","5"]
        ,[".",".",".",  ".","8",".",  ".","7","9"]]

test3 = [["8","3",".",  ".","7",".",  ".",".","."]
        ,["6",".",".",  "1","9","5",  ".",".","."]
        ,[".","9","8",  ".",".",".",  ".","6","."]

        ,["5",".",".",  ".","6",".",  ".",".","3"]
        ,["4",".",".",  "8",".","3",  ".",".","1"]
        ,["7",".",".",  ".","2",".",  ".","7","6"]

        ,[".","6",".",  ".",".",".",  "2","8","."]
        ,[".",".",".",  "4","1","9",  ".",".","5"]
        ,[".",".",".",  ".","8",".",  ".","7","9"]]

test4 = [["8","3",".",  ".","7",".",  ".",".","."]
        ,["6",".",".",  "1","9","5",  ".",".","."]
        ,[".","9","8",  ".",".",".",  ".","6","."]

        ,["5",".",".",  ".","6",".",  ".",".","3"]
        ,["4",".",".",  "8",".","3",  ".",".","1"]
        ,["7",".",".",  ".","2",".",  ".","7","6"]

        ,[".","6",".",  "9",".",".",  "2","8","."]
        ,[".",".",".",  "4","1","9",  ".",".","5"]
        ,[".",".",".",  ".","8",".",  ".",".","9"]]

print(solver.isValidSudoku(test1)) # True
print(solver.isValidSudoku(test2)) # False
print(solver.isValidSudoku(test3)) # False
print(solver.isValidSudoku(test4)) # False