public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        for(int i = 0; i < numbers.Length; i++)
        {
            for (int j = i+1; j < numbers.Length; j++)
            {
                if (numbers[i] + numbers[j] > target)
                    break;
                else if (numbers[j] + numbers[i] == target)
                    return new int[] { i+1, j+1 };
            }
        }
        return new int[] { };
    }
}