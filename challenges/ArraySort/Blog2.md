consider the following array: [ 8,4,23,42,16,15]

To quick sort the array we will iterate through it and compare values, making swaps where necessary.

First we set two variables, left and right. These variables will equal the values of the elements at the first and last indecies of the array.

In this case: First = 8, Last = 15

Next, we set the "pivot" value, which is the value we will be sorting around. This value will also be set the value at the end of the array, so: Pivot = 15

Next we set a Low value, which will be equal to the left value plus 1
Right now, this value is -1

At this point we enter our loop, where we check if the current value is less than or equal to the pivot, and if it is we increment the Low value (to keep track of our placement), then swap the values.

After our first run of the for loop our array will look like this: 
	[8,4,23,42,16,15]
	i = 0
	and low = 0
	
Because while 8 is less than 15, it is already at the first place in the array.

In the second iteration, i = 1, arr[i] = 4. Because our value is greater than our pivot value (15), we will swap our values. 
	[4,8,23,42,16,15] => our value at low is swapped with our value at i
	i = 1
	low = 0

The next iteration has i = 2, arr[i] = 23. Now our value is greater than our pivot value, so no change occurs.
	[4,8,23,42,16,15]
	i = 2
	low = 1

In the next iteration, i = 3, arr[i] = 42, which is greater than our pivot so no change occurs. 
	[4,8,23,42,16,15]
	i = 3
	low = 1

Next Iteration:
	i = 4
	low = 1
	arr[i] = 16
	[4,8,23,42,16,15]
	no change

Next:
	i = 5
	low = 1
	arr[i] = 15
	[4,8,23,42,16,15]
no change occurs and this is the end of our first run through our loop. We will now recursively run the method again with the pivot value adjusted by 1 each time, so we get both ends of the array sorted. The final sort will set the pieces in order: [4,8,15,16,23,42]