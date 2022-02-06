namespace ProblemSolving.Problems
{
    /// <summary>
    /// 704. Binary Search
    /// https://leetcode.com/problems/binary-search/
    /// </summary>
    public class BinarySearch
    {
        public static int Search(int[] nums, int target)
        {
            if (nums.Length == 0) return -1;
            if (nums[0] > target || nums[nums.Length - 1] < target) return -1;

            int min = 0;
            int max = nums.Length - 1;
            int point;
            do
            {
                point = (min + max) / 2;
                if (nums[point] == target) return point;

                if (nums[point] > target)
                {
                    max = point - 1;
                }
                else
                {
                    min = point + 1;
                }
            }
            while(max >= min);

            return -1;
        }
    }
}