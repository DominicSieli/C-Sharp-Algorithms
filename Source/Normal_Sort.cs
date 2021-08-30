using System.Collections.Generic;

namespace Algorithms
{
	public class NormalSort
	{
		public static void Sort(List<int> list)
		{
			int min = list[0];
			int max = list[0];
			List<int> tempList(list.Count);

			for(int i = 0; i < list.Count; i++)
			{
				if(list[i] < min)
				{
					min = list[i];
				}

				if(list[i] > max)
				{
					max = list[i];
				}
			}

			for(int i = 0; i < list.size(); i++)
			{
				int index = (((float)list[i] - (float)min)) / (((float)max - (float)min)) * ((float)list.Count - 1);
				tempList[index] = list[i];
			}

			list = tempList;
		}
	}
}