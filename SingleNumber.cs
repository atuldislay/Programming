public class Solution {
    public int SingleNumber(int[] nums) {
        
        int result = 0;
        foreach(int i in nums)
        {
            result = result ^ i;
        }
        
        return result;
    }
}
