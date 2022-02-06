# You are given two lists of closed intervals, firstList and secondList, where firstList[i] = [starti, endi] and secondList[j] = [startj, endj]. Each list of intervals is pairwise disjoint and in sorted order.
# Return the intersection of these two interval lists.
# A closed interval [a, b] (with a <= b) denotes the set of real numbers x with a <= x <= b.
# The intersection of two closed intervals is a set of real numbers that are either empty or represented as a closed interval. For example, the intersection of [1, 3] and [2, 4] is [2, 3].

# 0 <= firstList.length, secondList.length <= 1000
# firstList.length + secondList.length >= 1
# 0 <= start_i < end_i <= 10^9
# endi < start_i+1
# 0 <= start_j < end_j <= 10^9
# endj < start_j+1

# @param {Integer[][]} first_list
# @param {Integer[][]} second_list
# @return {Integer[]}
def intersect(min_list, maj_list)
    if maj_list.length > 1 and min_list[0][1] >= maj_list[1][0]
        first = min_list[0]
        second = maj_list.shift
    else
        first = min_list.shift
        second = maj_list[0]
    end
    return [] if first[1]<second[0]
    [[first[1],second[0]].min, [first[1],second[1]].min]
end

# @param {Integer[][]} first_list
# @param {Integer[][]} second_list
# @return {Integer[][]}
def interval_intersection(first_list, second_list)
    intersection = []
    until first_list.empty? or second_list.empty?
        result = first_list[0][0]<second_list[0][0] ? intersect(first_list, second_list) : intersect(second_list, first_list)
        intersection << result unless result.empty?
    end
    intersection
end

p interval_intersection([[3,5],[9,20]], [[4,5],[7,10],[11,12],[14,15],[16,20]])
#[[4,5],[9,10],[11,12],[14,15],[16,20]]

p interval_intersection([[0,2],[5,10],[13,23],[24,25]],[[1,5],[8,12],[15,24],[25,26]])
#[[1,2],[5,5],[8,10],[15,23],[24,24],[25,25]]

p interval_intersection([[0,2],[5,10]],[])  #[]

p interval_intersection([[4,6],[7,8],[10,17]],[[5,10]])  #[[5,6],[7,8],[10,10]]