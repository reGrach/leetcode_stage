namespace TasksLib.MergeSortedArray;

/// <summary>
/// You are given two integer arrays nums1 and nums2, sorted in non-decreasing order,
/// and two integers m and n, representing the number of elements in nums1 and nums2 respectively.
/// Merge nums1 and nums2 into a single array sorted in non-decreasing order
/// The final sorted array should not be returned by the function,
/// but instead be stored inside the array nums1.
/// To accommodate this, nums1 has a length of m + n, where the first m elements
/// denote the elements that should be merged,
/// and the last n elements are set to 0 and should be ignored. nums2 has a length of n.
/// </summary>

public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        if (m == 0)
        {
            for (int i = 0; i < n; i++)
                nums1[i] = nums2[i];
        }
        else if (n != 0)
        {
            int i1 = 0;
            int i2 = 0;
            int[] newArray = new int[n + m];

            for (int j = 0; j < n + m; j++)
            {
                if (i1 >= m)
                {
                    newArray[j] = nums2[i2];
                    i2++;
                }
                else if (i2 < n && nums1[i1] > nums2[i2])
                {
                    newArray[j] = nums2[i2];
                    i2++;
                }
                else
                {
                    newArray[j] = nums1[i1];
                    i1++;
                }
            }

            for (int k = 0; k < n + m; k++)
                if (nums1[k] != newArray[k])
                    nums1[k] = newArray[k];
        }
    }
}
