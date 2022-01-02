# You are given an integer mass, which represents the original mass of a planet. You are further given an integer array asteroids, where asteroids[i] is the mass of the ith asteroid.
# You can arrange for the planet to collide with the asteroids in any arbitrary order. If the mass of the planet is greater than or equal to the mass of the asteroid, the asteroid is destroyed and the planet gains the mass of the asteroid. Otherwise, the planet is destroyed.
# Return true if all asteroids can be destroyed. Otherwise, return false.

# 1 <= mass <= 10^5
# 1 <= asteroids.length <= 10^5
# 1 <= asteroids[i] <= 10^5

def asteroids_destroyed(mass, asteroids)
    asteroids.sort!
    asteroids.each do |asteroid|
        return false if mass < asteroid
        mass += asteroid
    end
    return true
end

p asteroids_destroyed(10, [3,9,19,5,21])
p asteroids_destroyed(5, [4,9,23,4])