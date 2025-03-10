﻿//// C# implementation of right rotation
//// of an array K number of times
//using System;
//class Solution
//{
//	static void RightRotate(int[] a,
//							int n, int k)
//	{
//		k = k % n;

//		for (int i = 0; i < n; i++)
//		{
//			if (i < k)
//			{
//				Console.Write(a[n + i - k] + " ");
//			}
//			else
//			{
//				Console.Write(a[i - k] + " ");
//			}
//		}
//		Console.WriteLine();
//	}

//	// test
//	public static void Main(String[] args)
//	{
//		int[] Array = { 8,9,5,7,3};
//		int N = Array.Length;
//		int K = 3;

//		RightRotate(Array, N, K);
//	}
//}

// C# program for array rotation
using System;

class Solution
{
	/* Function to left rotate arr[]
	of size n by d*/
	static void leftRotate(int[] arr, int d, int n)
	{
		int i, j, k, temp;
		/* To handle if d >= n */
		d = d % n;
		int g_c_d = gcd(d, n);
		for (i = 0; i < g_c_d; i++)
		{
			/* move i-th values of blocks */
			temp = arr[i];
			j = i;
			while (true)
			{
				k = j + d;
				if (k >= n)
					k = k - n;
				if (k == i)
					break;
				arr[j] = arr[k];
				j = k;
			}
			arr[j] = temp;
		}
	}

	/*UTILITY FUNCTIONS*/
	/* Function to print an array */
	static void printArray(int[] arr, int size)
	{
		for (int i = 0; i < size; i++)
			Console.Write(arr[i] + " ");
	}

	/* Function to get gcd of a and b*/
	static int gcd(int a, int b)
	{
		if (b == 0)
			return a;
		else
			return gcd(b, a % b);
	}

	// Driver code
	public static void Main()
	{
		int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
		leftRotate(arr, 2, 7);
		printArray(arr, 7);
	}
}





