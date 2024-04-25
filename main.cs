public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) 
    {
        // base case
        if(nums.Length < 3) return new List<IList<int>>();
        // sort
        Array.Sort(nums);
        // List of lists
        List<IList<int>> triplets = new List<IList<int>>();
        // outer loop
        for(int i = 0; i < nums.Length -2; i++)
        {
          // if the first number is greater than 0 break, first number can't be greater than 0
          if(nums[i] > 0) break;
          // case for i duplicates
          if(i > 0 && nums[i] == nums[i-1]) continue;
          // int left is index plus 1
          int left = i + 1;
          // int right is max size minus 1
          int right = nums.Length -1;
          // while(left target is less than right)
          while(left < right)
          {
              int sum = nums[i] + nums[left] + nums[right];
              if(sum == 0)
              {
                  triplets.Add(new List<int>(){nums[i], nums[left], nums[right]});
                  // eliminate left duplicates
                  while(left < right && nums[left] == nums[left+1]) left++;
                  // eliminate right duplicates
                  while(left < right && nums[right] == nums[right - 1]) right--;
                  // advance the left
                  left++;
                  // advance the right
                  right--;
              }
              // too negative
              else if(sum < 0)
              {
                  left++;
              }
              // too positive
              else
              {
                  right--;
              }
          }
        }
        return triplets;
        // return List of Lists
    }
}
