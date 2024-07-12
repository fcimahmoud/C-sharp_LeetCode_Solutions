public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int m = nums1.Length, n = nums2.Length;
        int[] mergedArr = new int[m + n];

        int i = 0, j = 0, k = 0;
        while (i < m && j < n)
        {
            if (nums1[i] < nums2[j])
            { 
                mergedArr[k] = nums1[i]; 
                i++; 
            }
            else
            {
                mergedArr[k] = nums2 [j];
                j++;
            }
            k++;
        }
        while(i < m)
        {
            mergedArr[k] = nums1[i];
            k++; i++;
        }
        while (j < n)
        {
            mergedArr[k] = nums2[j];
            k++; j++;
        }

        if ((m + n) % 2 == 0)
            return (double)(mergedArr[(m + n) / 2] + mergedArr[((m + n) / 2) - 1]) / 2;
        else
            return mergedArr[(m + n) / 2];
    }
}