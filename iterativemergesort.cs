using System;

namespace Merge
{
    public static class Merger
    {
        public static int[] MergeSort(this int[] arr, int left, int right)
        {
            if(left < right)
            {
                int mid = left + right / 2;
                arr.MergeSort(left, mid);
                arr.MergeSort(mid+1, right);
                arr.Merge(left, mid, right);
            }
            return arr;
        }
        private static int[] Merge(this int[] arr, int left, int mid, int right) {
            return arr;
        }
        public static void Print(this int[] arr) {
            foreach(int i in arr) {
                Console.WriteLine(i);
            }
            return;
        }
        public static void InsertSort(this int[] arr) {
            for(int i = 1; i < arr.Length;)
            {
                int element = arr[i];
                int j = i - 1;
                if(j >= 0) {
                    arr[j+1] = arr[j];
                    j = j - 1;
                }
                else  {
                    ++i;
                }
            }
        }
        public static void IterativeMergeSort(this int[] arr) {
            int leftPosition = 0;
            int counter = 0;
            int rightPosition = arr.Length - 1;
            int iterator = 0;
            int[] position = new int[arr.Length];
            position[iterator] = leftPosition;
            position[++iterator] = rightPosition; 
            while (iterator >= 0) {
                counter++;
                rightPosition = position[iterator--];
                leftPosition = position[iterator--];
                int i = leftPosition - 1;
                int temp = 0;
                for(int j = leftPosition; j <= rightPosition - 1; ++j)
                {
                    counter++;
                    if(arr[j] <= arr[rightPosition]) {
                        ++i;
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
                temp = arr[i + 1];
                arr[i + 1] = arr[rightPosition];
                arr[rightPosition] = temp;
                int midPosition = i + 1;
                if(leftPosition < midPosition - 1) {
                    position[++iterator] = leftPosition;
                    position[++iterator] = midPosition - 1;
                }
                if(midPosition + 1 < rightPosition) {
                    position[++iterator] = midPosition + 1;
                    position[++iterator] = rightPosition;
                }
            }
            Console.WriteLine("COUNTER"+counter);
        }

    }
    public class Program
    {
        public static void Main(string[] arg)
        {
            int[] arr = new int[]{15,21,11,10,1,99,66,250,-1,20,55};
        //    arr.MergeSort(0, arr.Length-1);            
           // arr.InsertSort();
            arr.IterativeMergeSort();
            arr.Print();
        }
    }
}
