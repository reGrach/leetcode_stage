﻿namespace TasksLib.TwoSum;

/// <summary>
/// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
/// You may assume that each input would have exactly one solution, and you may not use the same element twice.
/// You can return the answer in any order.
/// </summary>

public class Solution
{
    public static int[] Run(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            int target2 = target - nums[i];

            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[j] == target2)
                {
                    return [i, j];
                }
            }
        }

        return [0, 0];
    }
}
