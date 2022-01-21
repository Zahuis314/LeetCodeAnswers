// There are n gas stations along a circular route, where the amount of gas at the ith station is gas[i].
// You have a car with an unlimited gas tank and it costs cost[i] of gas to travel from the ith station to its next (i + 1)th station. You begin the journey with an empty tank at one of the gas stations.
// Given two integer arrays gas and cost, return the starting gas station's index if you can travel around the circuit once in the clockwise direction, otherwise return -1. If there exists a solution, it is guaranteed to be unique

// gas.length == n
// cost.length == n
// 1 <= n <= 10^5
// 0 <= gas[i], cost[i] <= 10^4

/**
 * @param {number[]} gas
 * @param {number[]} cost
 * @return {number}
 */
var canCompleteCircuit = function(gas, cost) {
    var total = 0;
    for (let i = 0; i < gas.length; i++) {
        total += gas[i]-cost[i];
    }
    if(total<0) { return -1; }

    var currentGas=0, startingIndex = 0;
    for (let i = 0; i < gas.length; i++) {
        currentGas += gas[i]-cost[i];
        if(currentGas<0){
            currentGas = 0;
            startingIndex = i+1;
        }
    }
    return startingIndex;
};
console.log(canCompleteCircuit([1,2,3,4,5],[3,4,5,1,2])==3);
console.log(canCompleteCircuit([2,3,4],[3,4,3])==-1);