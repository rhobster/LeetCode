public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] indices = new int[]{-1, -1};
        int baseIndex = 0;
        while(baseIndex < nums.Length - 1){
            for(int i = baseIndex + 1; i < nums.Length; i++){
                if(nums[baseIndex] + nums[i] == target){
                    indices[0] = baseIndex;
                    indices[1] = i;
                    return indices;
                }
            }
            baseIndex++;
        } 
        //it should never get here. but this would be n^2 because it goes through nums twice.
        return indices;
    }
}