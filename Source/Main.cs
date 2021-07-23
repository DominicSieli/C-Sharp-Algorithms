using System;
using System.Collections.Generic;

class Test
{
	static void Main()
	{
		List<int> list = new List<int>(){245,43,18,165,2,64,8};
		Algorithms.Radix_Sort(list);

		for(int i = 0; i < list.Count; i++)
		{
        	Console.WriteLine(list[i]);
		}
	}
}