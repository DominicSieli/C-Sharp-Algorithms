using System.Collections.Generic;

namespace Algorithms
{
	public static class BinarySearch
	{
		public static int Search(List<int> list, int target)
		{
			int left = 0;
			int median = 0;
			int right = list.Count - 1;

			if(target < list[left] || target > list[right]) return -1;

			while(left <= right)
			{
				median = left + (right - left) / 2;

				if(list[left] == target) return left;
				if(list[right] == target) return right;
				if(list[median] == target) return median;
				if(list[median] < target) left = median + 1;
				if(list[median] > target) right = median - 1;
			}

			return -1;
		}
	}
}