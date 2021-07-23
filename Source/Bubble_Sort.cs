using System.Collections.Generic;

public class Algorithms
{
    public static void Bubble_Sort(List<int> list)
    {
        if(list.Count < 2) return;

        bool sorted = false;

        while(sorted == false)
        {
            sorted = true;

            for(int i = 0; i < list.Count - 1; i++)
            {
                if(list[i] > list[i + 1])
                {
                    sorted = false;
                    int i1 = list[i];
                    int i2 = list[i + 1];
                    list[i] = i2;
                    list[i + 1] = i1;
                }
            }
        }
    }
}