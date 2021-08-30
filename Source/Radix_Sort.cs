using System.Collections.Generic;

namespace Algorithms
{
	public class RadixSort
	{
		public static void Sort(List<int> list)
		{
			Queue<int>[] buckets = new Queue<int>[10];

			int max = list[0];

			for(int i = 0; i < list.Count; ++i)
			{
				if(max < list[i]) max = list[i];
			}

			for(int exp = 1; max/exp > 0; exp *= 10)
			{
				for(int i = 0; i < list.Count; ++i)
				{
					buckets[(list[i]/exp)%10].Enqueue(list[i]);
				}

				int list_counter = 0;

				for(int i = 0; i < 10; ++i)
				{
					foreach(var x in buckets[i])
					{
						list[list_counter++] = x;
						buckets[i].Dequeue();
					}
				}
			}

			return;
		}
	}
}