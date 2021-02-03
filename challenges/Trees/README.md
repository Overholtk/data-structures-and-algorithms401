# Trees
A data structure comprised of branches and leaves (nodes), especially good for searching for specific values.

## Challenge
Set up the trees project to include all basic methods for a simple Binary Tree and a Binary Search Tree

## Approach and Efficiency & API
### PreOrder:
Adds the root value to the list, then iterates through the rest of the tree by checking if the current node has an availible left node, then right node, and running the method again on those nodes.

O(logN) effieciency (time)

O(N) effieciency (space)

### InOrder & PostOrder:
Work the same way as PreOrder but in a different order- left, root, right for InOrder, and left, right, root for PostOrder

### Add:
Instantiates a new node and then adds it to the tree in it's applicable place. Checks to see if a root exists and places the node there if it is empty, otherwise checks the value against the node chosen to append the new node to and places it on either the left or right side.

O(N) Time

O(1) Space

### Contains:
Checks whether the value chosen is greater than, less than, or equal to the chosen node adn re runs itself until the correct value is found. Defaults to false value if the value is never found.

O(LogN) Time
O(1) Space

### BreadthTraversal:
Traverse through a tree and output a list of values ordered in the way they would be encountered in a list. This method grabs a node and inserts it into the list, then grabs that node's left and right properties. It continues to run recursively by grabbing subtrees and putting the root value into the list, and then returns a value once all the nodes come back as null.

O(N) Time
O(N) Space
