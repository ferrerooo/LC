// https://leetcode.com/problems/merge-sorted-array/


public class Solution88 {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        
        if (m == 0) {
            for (int i = n - 1; i >= 0; i--)
                nums1[i] = nums2[i];
            
            return;
        }
        
        int cur = m + n - 1;
        
        int p1 = m - 1;
        int p2 = n - 1;
        
        while (p1 >= 0 && p2 >= 0) {
            
            if (nums1[p1] >= nums2[p2]) {
                nums1[cur] = nums1[p1];
                p1--;
            } else {
                nums1[cur] = nums2[p2];
                p2--;
            }
            cur--;
        }
        
        while (p2 >= 0) {
            nums1[cur] = nums2[p2];
            cur--;
            p2--;
        }
        
        return;
    }
}
