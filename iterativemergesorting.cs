using System;

namespace Merge

{
	internal static class Merge
	{
		public static void IterativeQuickSort(this int[] arr)
	    {
	    	int leftPos = 0;
	    	int rightPos = arr.Length - 1;
	    	int idxPtr = 0;
	    	int[] position = new int[arr.Length];
	    	position[idxPtr] = leftPos;
	    	position[++idxPtr] = rightPos;
	    	while(idxPtr >= 0)
	    	{
	    		rightPos = position[idxPtr--];
	    		leftPos = position[idxPtr--];
	   
	    		int i = leftPos - 1;
	    		for(int j = leftPos; j <= rightPos - 1; ++j)
	    		{
	    			// a * (bool)(a / b) + b * (bool)(b / a)
	    			if(arr[j] <= arr[rightPos])
	    			{
	    				++i;
	    				swap(ref arr[i], ref arr[j]);
	    			}
	    		}
	    		int midPos = i + 1;
	    		swap(ref arr[midPos], ref arr[rightPos]);
	    		if(leftPos < midPos - 1)
	    		{
	    			position[++idxPtr] = leftPos;
	    			position[++idxPtr] = midPos - 1;
	    		}
	    		if(midPos + 1 < rightPos)
	    		{
	    			position[++idxPtr] = midPos + 1;
	    			position[++idxPtr] = rightPos;
	    		}
	    	}
	    	return;
	    }
	    private static void swap(ref int a, ref int b)
	    {
	    	int temp = a;
	    	a = b;
	    	b = temp;
	        return;
	    }
		
		public static void Print(this int[] arr)
		{
			if(arr.Length < 1)
			return;
			
			foreach(int i in arr)
			Console.WriteLine(i);
			
			return;
		}
	}
	
	public class Program
	{
		int[] arr = new int[]{ 1, 66, 25,999,532,51,14,69,1993,201,-1,0};
		public static void Main(string[] args)
		{
			Program p = new Program();
			
			p.arr.IterativeQuickSort();
			p.arr.Print();
		}
		
	};
}
