using System.Collections.Generic;

public class Algorithms
{
    public static void Insertion_Sort(List<int> list)
    {
        for(int i = 0; i < list.Count; i++)
        {
            int j;
            int reference_value = list[i];

            for(j = i - 1; j >= 0; j--)
            {
                if(list[j] > reference_value)
                {
                    list[j + 1] = list[j];
                }
                else
                {
                    break;
                }
            }

            list[j + 1] = reference_value;
        }
    }
}