using System.Collections.Generic;

namespace Algorithms
{
	public static class RadixSort
	{
		public static void Sort(List<int> list)
		{
			int max = list[0];
			Queue<int>[] buckets = new Queue<int>[10];
			for(int i = 0; i < buckets.Length; i++) buckets[i] = new Queue<int>();

			for(int i = 0; i < list.Count; i++)
			{
				if(max < list[i]) max = list[i];
			}

			for(int exp = 1; max/exp > 0; exp *= 10)
			{
				for(int i = 0; i < list.Count; i++)
				{
					buckets[(list[i]/exp)%10].Enqueue(list[i]);
				}

				int listCounter = 0;

				for(int i = 0; i < 10; i++)
				{
					while(buckets[i].Count > 0)
					{
						list[listCounter++] = buckets[i].Peek();
						buckets[i].Dequeue();
					}
				}
			}
		}
	}
}