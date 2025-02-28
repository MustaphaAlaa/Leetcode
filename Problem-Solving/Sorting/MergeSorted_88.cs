
using System.Globalization;

namespace Problem_Solving_Sorting;

public class MergeSorted /*#88*/
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        for (int i = m; i < (m + n); i++)
            nums1[i] = nums2[i - m];
        this.SortedArr = new int[nums1.Length];
        Sort(nums1, 0, nums1.Length - 1);
    }

    public void Sort(int[] arr, int start, int end)
    {
        if (start == end)
            return;
        int mid = start + (end - start) / 2;
        Sort(arr, start, mid);
        Sort(arr, mid + 1, end);
        MergeSorting(arr, start, mid, end);
    }

    private void MergeSorting(int[] arr, int start, int mid, int end)
    {
        for (int i = start, j = mid + 1, k = start; k <= end; k++)
        {
            if (i > mid)
                SortedArr[k] = arr[j++];
            else if (j > end)
                SortedArr[k] = arr[i++];
            else if (arr[i] < arr[j])
                SortedArr[k] = arr[i++];
            else
                SortedArr[k] = arr[j++];
        }

        for (int i = start; i <= end; i++)

            arr[i] = SortedArr[i];

    }

    int[] SortedArr;

}