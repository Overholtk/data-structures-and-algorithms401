using System;

namespace ArraySort
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        public void InsertionSort(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = i - 1; j < arr.Length; j++)
                {
                    int temp = arr[i];

                    while(j >= 0 && temp < arr[j])
                    {
                        arr[j] = arr[j + 1];
                    };
                }
            }
        }


        public void QuickSort(int[] arr, int left, int right)
        {
            //if left is less than right
            // position = Partition(arr, left, right)
        }

        public void Partition(int[] arr, int left, int right)
        {
            //set pivot value: pivot = arr[right]
            //
        }
    }
}
