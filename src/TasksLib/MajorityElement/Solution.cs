namespace TasksLib.MajorityElement;

/// <summary>
/// Given an array nums of size n, return the majority element
/// 
/// The majority element is the element that appears more than ⌊n / 2⌋ times.
/// You may assume that the majority element always exists in the array.
/// </summary>

public class Solution
{
    public int MajorityElement(int[] nums)
    {
        decimal half = Math.Round(nums.Length / 2m, 1);
        bool[] ignore = new bool[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            if (!ignore[i])
            {
                int _count = 0;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        _count++;
                        ignore[j] = true;

                        if (_count > half)
                            return nums[i];
                    }

                    if (_count + nums.Length - j < half)
                        break;
                }
            }
        }

        return 0;
    }

    public int MajorityElement_First(int[] nums)
    {
        var numsCount = new Dictionary<int, int>();

        foreach (int num in nums)
        {
            if (numsCount.ContainsKey(num))
            {
                numsCount[num]++;
            }
            else
            {
                numsCount.Add(num, 1);
            }
        }

        return numsCount.OrderByDescending(x => x.Value).First().Key;
    }
}
