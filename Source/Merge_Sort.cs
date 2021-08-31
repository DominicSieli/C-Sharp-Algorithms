using System.Collections.Generic;

namespace Algorithms
{
	public static class MergeSort
	{
		private static void Merge(List<int> list, int startIndex, int middleIndex, int endIndex)
		{
			int totalElements = (endIndex - startIndex) + 1;
			List<int> sortList = new List<int>(new int[totalElements]);

			int mergeIndex = 0;
			int leftIndex = startIndex;
			int rightIndex = middleIndex + 1;

			while(leftIndex <= middleIndex && rightIndex <= endIndex)
			{
				if(list[leftIndex] <= list[rightIndex])
				{
					sortList[mergeIndex++] = list[leftIndex++];
				}
				else
				{
					sortList[mergeIndex++] = list[rightIndex++];
				}
			}

			while(leftIndex <= middleIndex)
			{
				sortList[mergeIndex++] = list[leftIndex++];
			}

			while(rightIndex <= endIndex)
			{
				sortList[mergeIndex++] = list[rightIndex++];
			}

			for(int i = 0; i < totalElements; i++)
			{
				list[startIndex + i] = sortList[i];
			}
		}

		public static void Sort(List<int> list, int startIndex, int endIndex)
		{
			if(startIndex < endIndex)
			{
				int middleIndex = (startIndex + endIndex) / 2;

				Sort(list, startIndex, middleIndex);
				Sort(list, middleIndex + 1, endIndex);
				Merge(list, startIndex, middleIndex, endIndex);
			}
		}
	}
}