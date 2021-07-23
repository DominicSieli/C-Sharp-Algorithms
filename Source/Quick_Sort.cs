using System.Collections.Generic;

public class Algorithms
{
    private static int Partition(List<int> list, int start_index, int end_index)
    {
        int pivot = list[start_index];
        int middle_index = start_index;

        for(int i = start_index + 1; i <= end_index; ++i)
        {
            if(list[i] < pivot)
            {
                ++middle_index;
                int a = list[i];
                int b = list[middle_index];
                list[i] = b;
                list[middle_index] = a;
            }
        }

        int x = list[start_index];
        int y = list[middle_index];
        list[start_index] = y;
        list[middle_index] = x;
        
        return middle_index;
    }

    public static void Quick_Sort(List<int> list, int start_index, int end_index)
    {
        if(start_index < end_index)
        {
            int pivot_index = Partition(list, start_index, end_index);

            Quick_Sort(list, start_index, pivot_index - 1);
            Quick_Sort(list, pivot_index + 1, end_index);
        }
    }
}