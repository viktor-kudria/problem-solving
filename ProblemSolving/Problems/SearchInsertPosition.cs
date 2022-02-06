namespace ProblemSolving.Problems
{
    /// <summary>
    /// 35. Search Insert Position
    /// https://leetcode.com/problems/search-insert-position/
    /// </summary>
    public class SearchInsertPosition
    {
        public static int SearchInsert(int[] nums, int target)
        {
            if (nums.Length == 0) return 0;
            if (nums[0] > target) return 0;
            if (nums[nums.Length - 1] < target) return nums.Length;

            int min = 0;
            int max = nums.Length - 1;
            int point;
            do
            {
                point = min + (max - min) / 2;
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
            return min;
        }
    }
}