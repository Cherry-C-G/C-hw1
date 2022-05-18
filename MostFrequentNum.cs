
// C# program to find the most
// frequent element in an array
using System;
using System.Collections.Generic;

class MostFrequentNum
{
	static int mostFrequent(int[] arr,int n)
	{
		// Insert all elements in hash
		Dictionary<int, int> hp =new Dictionary<int, int>();

		for (int i = 0; i < n; i++)
		{
			int key = arr[i];
			if (hp.ContainsKey(key))
			{
				int freq = hp[key];
				freq++;
				hp[key] = freq;
			}
			else
				hp.Add(key, 1);
		}

		// find max frequency.
		int min_count = 0, res = -1;

		foreach (KeyValuePair<int,int> pair in hp)
		{
			if (min_count < pair.Value)
			{
				res = pair.Key;
				min_count = pair.Value;
			}
		}
		return res;
	}

	// Driver code
	static void Main()
	{
		int[] arr = new int[] { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
		int n = arr.Length;

		Console.Write(mostFrequent(arr, n));
	}
}


