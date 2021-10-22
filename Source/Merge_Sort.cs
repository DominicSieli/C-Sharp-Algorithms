using System.Collections.Generic;

namespace Algorithms
{
	public static class MergeSort
	{
		private static void Merge(int[] array, int startIndex, int middleIndex, int endIndex)
		{
			int totalElements = (endIndex - startIndex) + 1;
			int[] sortList = new int[totalElements];

			int mergeIndex = 0;
			int leftIndex = startIndex;
			int rightIndex = middleIndex + 1;

			while(leftIndex <= middleIndex && rightIndex <= endIndex)
			{
				if(array[leftIndex] <= array[rightIndex])
				{
					sortList[mergeIndex++] = array[leftIndex++];
				}
				else
				{
					sortList[mergeIndex++] = array[rightIndex++];
				}
			}

			while(leftIndex <= middleIndex)
			{
				sortList[mergeIndex++] = array[leftIndex++];
			}

			while(rightIndex <= endIndex)
			{
				sortList[mergeIndex++] = array[rightIndex++];
			}

			for(int i = 0; i < totalElements; i++)
			{
				array[startIndex + i] = sortList[i];
			}
		}

		public static void Sort(int[] array, int startIndex, int endIndex)
		{
			if(startIndex < endIndex)
			{
				int middleIndex = (startIndex + endIndex) / 2;

				Sort(array, startIndex, middleIndex);
				Sort(array, middleIndex + 1, endIndex);
				Merge(array, startIndex, middleIndex, endIndex);
			}
		}
	}
}