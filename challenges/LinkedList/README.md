# Code Challenge 5: Linked Lists

## Challenge Summary
This challenge required instantiating linked lists and then working with them in various ways, inserting values into the beginning of the list, determining if a value is included in the list, and returning a string that contained every value in the list.

## Challenge Description and Approach & Efficiency

### Insert:
The insert method takes in a value as a parameter and inserts it into the head of the array. It does so by setting a current node variable to the head, then setting the next value of that node to the same element. Then, once the element is saved as the next value, it updates the head with the value of the input.

This is a O(1) space and time operation

### Includes:
This method takes in a value then loops over the array, checking the Value property of each node. If it finds a value it changes a previously instantiated boolean from false to true, then once the while loop has finished the method returns that boolean.

This is a O(N) operation

### toString:
The toString method loops through the whole array via a while loop and then adds the current value to a pre existing string, then returns the string at the end of the method. The while loop runs by checking that the Next value has a value.
This is a O(N) operation