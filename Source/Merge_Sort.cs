using System.Collections.Generic;

public class Algorithms
{
    private static void Merge(List<int> list, int start_index, int middle_index, int end_index)
    {
        int total_elements = end_index - start_index + 1;

        List<int> temp_list = new List<int>(total_elements);

        int left_index = start_index;
        int right_index = middle_index + 1;
        int merge_index = 0;

        while(left_index <= middle_index && right_index <= end_index)
        {
            if(list[left_index] <= list[right_index])
            {
                temp_list[merge_index] = list[left_index];
                ++left_index;
            }
            else
            {
                temp_list[merge_index] = list[right_index];
                ++right_index;
            }

            ++merge_index;
        }

        while(left_index <= middle_index)
        {
            temp_list[merge_index] = list[left_index];
            ++left_index;
            ++merge_index;
        }

        while(right_index <= end_index)
        {
            temp_list[merge_index] = list[right_index];
            ++right_index;
            ++merge_index;
        }

        for(int i = 0; i < total_elements; ++i)
        {
            list[start_index + i] = temp_list[i];
        }

        return;
    }

    public static void Merge_Sort(List<int> list, int start_index, int end_index)
    {
        if(start_index < end_index)
        {
            int middle_index = (start_index + end_index) / 2;

            Merge_Sort(list, start_index, middle_index);
            Merge_Sort(list, middle_index + 1, end_index);
            Merge(list, start_index, middle_index, end_index);
        }

        return;
    }
}