public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int difference;
        int[] result = new int[2];
        Hashtable Differences = new Hashtable();
        Differences.Add(nums[0],0);
        for (int i=1; i<nums.Length; i++){
            
            difference = target-nums[i];
            if (Differences.Contains(difference)){
                result[0]=(int)Differences[difference];
                result[1]=i;
            }
            else{
                Differences.Add(nums[i],i);
            }
        }
        
       return result; 
    }
}