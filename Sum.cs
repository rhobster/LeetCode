public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        /* My Original Solution, O(n^2)
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
        */

        //Better Solution, O(n)
        Dictionary<int,int> dic = new Dictionary<int,int>();
    
        for(int i = 0; i < nums.Length; i++)
        {
            if(dic.ContainsKey(target - nums[i]))
                return new int[]{i, dic[target - nums[i]]};
            else if(!dic.ContainsKey(nums[i]))
                dic.Add(nums[i], i);
        }
        
        return new int[]{-1, -1};;
    }
}