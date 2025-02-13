/*
Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.


Example 1:

Input: nums = [1,2,3,1]

Output: true

Explanation:

The element 1 occurs at the indices 0 and 3.

Example 2:

Input: nums = [1,2,3,4]

Output: false

Explanation:

All elements are distinct.


*/

public class Solution {
    public bool ContainsDuplicate(int[] nums) {

        HashSet <int> dublicated = new HashSet <int>();

        foreach (int num in nums)
        {
         if(dublicated.Contains(num)){
            return true;
         }
         dublicated.Add(num);
        }
        return false;

    }
}
