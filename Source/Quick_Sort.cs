using System.Collections.Generic;

namespace Algorithms
{
	public class QuickSort
	{
		private static int Partition(List<int> list, int startIndex, int endIndex)
		{
			int pivot = list[startIndex];
			int middleIndex = startIndex;

			for(int i = startIndex + 1; i <= endIndex; ++i)
			{
				if(list[i] < pivot)
				{
					++middleIndex;
					int a = list[i];
					int b = list[middleIndex];
					list[i] = b;
					list[middleIndex] = a;
				}
			}

			int x = list[startIndex];
			int y = list[middleIndex];
			list[startIndex] = y;
			list[middleIndex] = x;
			
			return middleIndex;
		}

		public static void Sort(List<int> list, int startIndex, int endIndex)
		{
			if(startIndex < endIndex)
			{
				int pivotIndex = Partition(list, startIndex, endIndex);

				Sort(list, startIndex, pivotIndex - 1);
				Sort(list, pivotIndex + 1, endIndex);
			}
		}
	}
}