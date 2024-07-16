public class Solution {
    public int FindPeakElement(int[] nums) {
        int maxElement = nums.Max();
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == maxElement)
                return i;
        }
        return -1;
    }
}