using System.Collections.Generic;

public class Algorithms
{
    public static void Counting_Sort(List<int> list)
    {
        int n = list.Count;
        List<int> count = new List<int>(n);
        List<int> output = new List<int>(n);
 
        for(int i = 0; i < count.Count; ++i) count[i] = 0;
        for(int i = 0; i < n; ++i) ++count[list[i]];
        for(int i = 1; i <= count.Count; ++i) count[i] += count[i - 1];

        for(int i = n - 1; i >= 0; i--)
        {
            output[count[list[i]] - 1] = list[i];
            --count[list[i]];
        }

        for(int i = 0; i < n; ++i) list[i] = output[i];
    }
}