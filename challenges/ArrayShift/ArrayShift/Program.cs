using System;

namespace ArrayShift
{
    class ArrayShift
    {
        static void Main(string[] args)
        {
            InsertShiftArray(new int[4] { 0, 1, 2, 3 }, 4); 
        }

        static int[] InsertShiftArray(int[] arr, int num)
        {
            for(var i = 0; i < arr.Length; i++)
            {
            Console.WriteLine(arr[i]);
            }
            int mid = 0;
            int length = arr.Length;
            int l = length + 1;
            if(length % 2 == 0)
            {
                mid = length / 2;
            }
            else
            {
                mid = (length / 2) + 1;
            }
            int[] newArr = new int[l];
            newArr[mid] = num;
            for(int i = 0; i < l; i++)
            {
                if(i < mid)
                {
                    newArr[i] = arr[i];
                }
                if(i > mid)
                {
                    newArr[i] = arr[i - 1];
                }
            }
            for(int i = 0; i < newArr.Length; i++)
            {
            Console.WriteLine(newArr[i]);
            }
            return newArr;
        }
    }
}
