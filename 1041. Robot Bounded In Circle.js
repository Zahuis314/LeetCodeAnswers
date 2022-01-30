// On an infinite plane, a robot initially stands at (0, 0) and faces north. Note that:
// The north direction is the positive direction of the y-axis.
// The south direction is the negative direction of the y-axis.
// The east direction is the positive direction of the x-axis.
// The west direction is the negative direction of the x-axis.
// The robot can receive one of three instructions:
// "G": go straight 1 unit.
// "L": turn 90 degrees to the left (i.e., anti-clockwise direction).
// "R": turn 90 degrees to the right (i.e., clockwise direction).
// The robot performs the instructions given in order, and repeats them forever.
// Return true if and only if there exists a circle in the plane such that the robot never leaves the circle.

// 1 <= instructions.length <= 100
// instructions[i] is 'G', 'L' or, 'R'.

/**
 * @param {string} instructions
 * @return {boolean}
 */
var isRobotBounded = function(instructions) {
    var dir = 0, pos = [0,0];
    var steps = [[-1,0],[0,1],[1,0],[0,-1]];
    for (let index = 0; index < instructions.length; index++) {
        const char = instructions[index];
        switch (char) {
            case "L":
                dir=(dir+1)%4;
                break;
            case "R":
                dir=(dir+3)%4;
                break;
            case "G":
                pos[0]+=steps[dir][0];
                pos[1]+=steps[dir][1];
                break;
        }
    }
    return (pos[0]==0 && pos[1]==0) || dir != 0;
};

console.log(isRobotBounded("GGLLGG")==true);
console.log(isRobotBounded("GLLLLLLG")==true);
console.log(isRobotBounded("GRRRRRRG")==true);
console.log(isRobotBounded("GG")==false);
console.log(isRobotBounded("GL")==true);