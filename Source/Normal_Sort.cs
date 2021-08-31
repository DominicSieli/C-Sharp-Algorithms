using System.Collections.Generic;

namespace Algorithms
{
	public static class NormalSort
	{
		public static void Sort(List<int> list)
		{
			int min = list[0];
			int max = list[0];
			List<int> sortList = new List<int>(new int[list.Count]);

			for(int i = 0; i < list.Count; i++)
			{
				if(list[i] < min) min = list[i];
				if(list[i] > max) max = list[i];
			}

			for(int i = 0; i < list.Count; i++)
			{
				int index = (int)(((float)(list[i] - min) / (float)(max - min)) * (list.Count - 1));
				sortList[index] = list[i];
			}
			
			list.Clear();
			list.AddRange(sortList);
		}
	}
}