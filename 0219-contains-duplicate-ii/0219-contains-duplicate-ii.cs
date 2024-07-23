public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        List <int> list = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if(list.Contains(nums[i]))
                return true;
            list.Add(nums[i]);

            if(list.Count > k)
                list.Remove(nums[i - k]);

        }
        return false;
    }
}