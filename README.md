Read Me
===================================

This repo's goal is to turn equations into trees and trees into a solution

# 1
5 + 3 * 4

# 2
	    +
       / \
      5   *
         / \
        3   4

# 3
17

# Nothering is ever that simple
* Depending on the order of how the equation is solved different answers can be produced. 
* 5 + 3 * 4 can equal 17 or 32.
* This can be addressed by following BIDMAS. BIDMAS stands for Brackets, Indices, Division, Multiplication, Addition, Subtraction.
* The tree above is solved from bottom up thereford stronger binding calculations are nearer the bottom.

# There are two different types of equations
- Two numbers and a symbol, for example 
  - 5+6 
  - 77/11
  - Note the more complex equation can be reduced to this 
    - 5+3*4 = 5+12
- One symbol and one number 
  - 10!
  - √100
  - Note that there are two variants, symbol on the left or right
