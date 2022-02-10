// Given a directed acyclic graph (DAG) of n nodes labeled from 0 to n - 1, find all possible paths from node 0 to node n - 1 and return them in any order.
// The graph is given as follows: graph[i] is a list of all nodes you can visit from node i (i.e., there is a directed edge from node i to node graph[i][j]).

const { result } = require("lodash");

// n == graph.length
// 2 <= n <= 15
// 0 <= graph[i][j] < n
// graph[i][j] != i (i.e., there will be no self-loops).
// All the elements of graph[i] are unique.
// The input graph is guaranteed to be a DAG.

/**
 * @param {number[][]} graph
 * @return {number[][]}
 */
var allPathsSourceTarget = function(graph) {
    var queue = [[0]], tail_index = graph.length-1, result = [];
    while (queue.length!=0) {
        var tail = queue.shift();
        graph[tail[tail.length-1]].forEach(node => {
            if(node==tail_index) result.push([...tail,node])
            else queue.push([...tail,node])
        });
    }
    return result;
};
console.log(allPathsSourceTarget([[1,2],[3],[3],[]]));          // [[0,1,3],[0,2,3]]
console.log(allPathsSourceTarget([[4,3,1],[3,2,4],[3],[4],[]]));// [[0,4],[0,3,4],[0,1,3,4],[0,1,2,3,4],[0,1,4]]