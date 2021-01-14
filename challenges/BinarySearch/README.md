# Reverse an Array

## Challenge:
Take in an array of numbers and a search value, then search the array using the binary search method to determine if the array contains the value.

## Approach and Efficiency
I chose to use a variable accessible to the whole method and then update it, returning that value at the end. I did this because I could default the variable value to the expected output if the value could not be found in the array, and then conditionally update it if it is found. I used a while loop that ran based on a boolean to continuously check the array, and then set the boolean to exit the while loop once the index number to be checked was outside the bounds of the array.

## Solution

![Whiteboard Solution]()
