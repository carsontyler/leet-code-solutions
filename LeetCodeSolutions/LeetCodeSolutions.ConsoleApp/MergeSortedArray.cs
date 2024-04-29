public class MergeSortedArray {

    public static void Run(){
        var nums1 = new int[] {1,2,3,0,0,0};
        var m = 3;
        var nums2 = new int[] {2,5,6};
        var n = 3;
        Merge(nums1, m, nums2, n);

        var expected = new int[] {1,2,2,3,5,6};
        var success = true;

        for (int i = 0; i < expected.Length; i++){
            if (expected[i] != nums1[i])
                success = false;
        }
        
        Console.WriteLine("Merge Sorted Array Success: " + success);
    }

    private static void Merge(int[] nums1, int m, int[] nums2, int n) {
        if (n == 0)
            return; 

        int a = m - 1, b = n - 1, c = m + n - 1;

        while (b >= 0){
            if (a >= 0 && nums1[a] > nums2[b]){
                nums1[c--] = nums1[a--];
            }
            else {
                nums1[c--] = nums2[b--];
            }
        }
    }
}