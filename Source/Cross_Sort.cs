using System.Collections.Generic;

public class Algorithms
{
	public static void Cross_Sort(List<int> list)
	{
		bool sorted = false;
		int j = 0;
		int l = 0;
		int r = list.Count - 1;

		while(sorted == false)
		{
			sorted = true;

			for(int i = l; i < r; i++)
			{
				j = (list.Count - i) - 1;

				if(i < j && list[i] > list[j])
				{
					sorted = false;
					int a = list[i];
					int b = list[j];
					list[i] = b;
					list[j] = a;
				}

				if(list[i] > list[i + 1])
				{
					sorted = false;
					int a = list[i];
					int b = list[i + 1];
					list[i] = b;
					list[i + 1] = a;
				}

				if(list[j] < list[j - 1])
				{
					sorted = false;
					int a = list[j];
					int b = list[j - 1];
					list[j] = b;
					list[j - 1] = a;
				}
			}

			l++;
			r--;
		}
	}
}