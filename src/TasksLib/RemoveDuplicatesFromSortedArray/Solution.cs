namespace TasksLib.RemoveDuplicatesFromSortedArray;

/// <summary>
/// Given an integer array nums sorted in non-decreasing order,
/// remove the duplicates in-place such that each unique element appears only once.
/// The relative order of the elements should be kept the same.
/// Then return the number of unique elements in nums.
/// 
/// Consider the number of unique elements of nums to be k, to get accepted, you need to do the following things:
/// 
/// Change the array nums such that the first k elements of nums
/// contain the unique elements in the order they were present in nums initially.
/// The remaining elements of nums are not important as well as the size of nums.
///
///Return k.
///
/// </summary>

public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int result = 0;
        // тривиальное решение - все элементы равны
        if (nums[0] == nums[nums.Length - 1])
        {
            result = 1;
        }
        else
        {
            int lastNumber = nums[0];
            int steps = 1;

            for (int i = 0; i < nums.Length; i++)
            {
                int j = i;
                while (lastNumber == nums[j] && j < nums.Length - 1)
                    j++;

                for (int k = i + 1; k < j; k++)
                {
                    nums[k] = nums[j];
                }

                if (lastNumber != nums[j])
                {
                    lastNumber = nums[j];
                    steps++;
                }

                if (lastNumber == nums[^1])
                    break;
            }

            result = steps;
        }

        return result;
    }

    public int RemoveDuplicates_Best(int[] nums)
    {
        int k = 0;
        int i = 0;
        int n = nums.Length;
        int prev = nums[0];

        while (i < n - 1)
        {
            while (i < n - 1 && nums[i] == nums[i + 1]) // to reach the last index of repeating number
            {
                i++; // updating i to the last same element occuring index 
            }

            nums[k] = nums[i]; // in place sorting.
            k++; // increament the index of unique elements
            i++;
        }

        if (i != n) // handling edge case what if last element is not a repeated number
        {
            nums[k] = nums[i];
            k++;
        }

        return k;
    }


    public int RemoveDuplicates_another(int[] nums)
    {
        var hash = new HashSet<int>(nums);
        for (int i = 0; i < hash.Count; i++)
            nums[i] = hash.ElementAt(i);

        return hash.Count;
    }
}
