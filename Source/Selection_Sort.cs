using System.Collections.Generic;

public class Algorithms
{
    public static void Selection_Sort(List<int> list)
    {
        int min_index = 0;

        for(int i = 0; i < list.Count; i++)
        {
            min_index = i;

            for(int j = i + 1; j < list.Count; j++)
            {
                if(list[j] < list[min_index]) min_index = j;
            }

            int a = list[i];
            int b = list[min_index];
            list[i] = b;
            list[min_index] = a;
        }
    }
}