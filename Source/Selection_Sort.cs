using System.Collections.Generic;

namespace Algorithms
{
	public class SelectionSort
	{
		public static void Sort(List<int> list)
		{
			int minIndex = 0;

			for(int i = 0; i < list.Count; i++)
			{
				minIndex = i;

				for(int j = i + 1; j < list.Count; j++)
				{
					if(list[j] < list[minIndex]) minIndex = j;
				}

				int a = list[i];
				int b = list[minIndex];
				list[i] = b;
				list[minIndex] = a;
			}
		}
	}
}