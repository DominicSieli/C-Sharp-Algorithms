using System.Collections.Generic;

namespace Algorithms
{
	public class MergeSort
	{
		private static void Merge(List<int> list, int startIndex, int middleIndex, int endIndex)
		{
			int totalElements = endIndex - startIndex + 1;

			List<int> tempList = new List<int>(totalElements);

			int leftIndex = startIndex;
			int rightIndex = middleIndex + 1;
			int mergeIndex = 0;

			while(leftIndex <= middleIndex && rightIndex <= endIndex)
			{
				if(list[leftIndex] <= list[rightIndex])
				{
					tempList[mergeIndex] = list[leftIndex];
					++leftIndex;
				}
				else
				{
					tempList[mergeIndex] = list[rightIndex];
					++rightIndex;
				}

				++mergeIndex;
			}

			while(leftIndex <= middleIndex)
			{
				tempList[mergeIndex] = list[leftIndex];
				++leftIndex;
				++mergeIndex;
			}

			while(rightIndex <= endIndex)
			{
				tempList[mergeIndex] = list[rightIndex];
				++rightIndex;
				++mergeIndex;
			}

			for(int i = 0; i < totalElements; ++i)
			{
				list[startIndex + i] = tempList[i];
			}

			return;
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

			return;
		}
	}
}