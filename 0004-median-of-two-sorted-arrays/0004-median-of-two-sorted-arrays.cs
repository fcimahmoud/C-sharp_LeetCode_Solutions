public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
            int m = nums1.Length, n = nums2.Length;
            int[] mergedArr = new int[m + n];

            for (int i = 0; i < m; i++)
                mergedArr[i] = nums1[i];
            for (int i = m; i < m + n; i++)
                mergedArr[i] = nums2[i - m];

            Array.Sort(mergedArr);
            if ((m + n) % 2 == 0)
                return (double)(mergedArr[(m + n) / 2] + mergedArr[((m + n) / 2) - 1]) / 2;
            else 
                return mergedArr[(m + n) / 2];
    }
}