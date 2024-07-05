public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int[] res = new int[nums.Length];
        int j = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                res[j] = nums[i];
                j++;
            }
        }
        for (int i = 0; i < j; i++)
        {
            nums[i] = res[i];
        }
        return j;
    }
}