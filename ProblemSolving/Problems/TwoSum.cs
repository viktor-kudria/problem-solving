namespace ProblemSolving.Problems
{
    /// <summary>
    /// 1. Two Sum
    /// https://leetcode.com/problems/two-sum/
    /// </summary>
    public class TwoSum
    {
        public static int[] Solve(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(target - nums[i])) return new [] {i, dict[target - nums[i]]};
                
                dict.TryAdd(nums[i], i);
            }
            
            return new int[] { -1, -1 };
        }
    }
}