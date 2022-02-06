namespace ProblemSolving.Problems
{
    /// <summary>
    /// 15. 3Sum
    /// https://leetcode.com/problems/3sum/
    /// </summary>
    public class ThreeSum
    {
        // O = n^3
        // doesn't work if we want to have only unique triplets and input array
        // doesn't contain distinct numbers
        public static IList<IList<int>> BruteForce(int[] nums) 
        {
            var result = new List<IList<int>>();
            if (nums.Length < 3) return result;

            for(int i = 0; i < nums.Length - 2; i++)
            {
                for (int j = i + 1; j < nums.Length - 1; j++)
                {
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        if (nums[i] + nums[j] + nums[k] == 0)
                            result.Add(new List<int>{ nums[i], nums[j], nums[k]});
                    }
                }
            }

            return result;
        }

        // 0 = n^2
        public static IList<IList<int>> BruteForceWithHash(int[] nums)
        {
            List<IList<int>> result = new List<IList<int>>();
            if (nums.Length < 3) return result;

            Dictionary<int, int> seen = new Dictionary<int, int>();
            HashSet<string> triplets = new HashSet<string>();

            for(int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (seen.ContainsKey(-nums[i] - nums[j]) && seen[-nums[i] - nums[j]] != i && seen[-nums[i] - nums[j]] != j)
                    {
                        var maybeResultItem = new int[] {- nums[i] - nums[j], nums[i], nums[j]};
                        Array.Sort(maybeResultItem);
                        if (triplets.Add($"{maybeResultItem[0]},{maybeResultItem[1]},{maybeResultItem[2]}"))
                        {
                            result.Add(maybeResultItem);
                        }
                        
                    }

                    seen.TryAdd(nums[j], j);
                }

                seen.TryAdd(nums[i], i);
            }

            return result;
        }
    }
}