namespace ProblemSolving.Problems
{
    /// <summary>
    /// 9. Palindrome Number
    /// https://leetcode.com/problems/palindrome-number/
    /// </summary>
    public class PalindromeNumber
    {
        public static bool IsPalindrome(int x) {
            if (x < 0) return false;
            if (x % 10 == 0 && x != 0) return false;

            int reverseNumber = 0;
            while(x > reverseNumber)
            {
                reverseNumber *= 10;
                reverseNumber += x % 10;

                x /=10;
            }

            return x == reverseNumber || x == reverseNumber / 10;
        }
    }
}