using System.Linq;
using System.Collections.Generic;

namespace Algorithms
{
	public static class CountingSort
	{
		public static void Sort(List<int> list)
		{
			int min = list.Min();
			int max = list.Max();
			int range = (max - min) + 1;
			List<int> count = new List<int>(new int[range]);
			List<int> output = new List<int>(new int[list.Count]);
			
			for(int i = 0; i < list.Count; i++) count[list[i] - min]++;
			for(int i = 1; i < count.Count; i++) count[i] += count[i - 1];
			
			for(int i = list.Count - 1; i >= 0; i--)
			{
				output[count[list[i] - min] - 1] = list[i];
				count[list[i] - min]--;
			}
			
			list.Clear();
			list.AddRange(output);
		}
	}
}