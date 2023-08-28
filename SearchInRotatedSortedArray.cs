public class Solution 
{
    public int Search(int[] nums, int target) 
    {
        int itemIndex = -1;

        for(int i = 0; i < nums.Length; i++) 
        {
            if(nums[i] == target)
            {
                itemIndex = i;
                break;
            }
        }

        return itemIndex;
    }
}
