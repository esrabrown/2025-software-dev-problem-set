/*
Given two strings s and t, return true if t is an anagram of s, and false otherwise.


Example 1:

Input: s = "anagram", t = "nagaram"

Output: true

Example 2:

Input: s = "rat", t = "car"

Output: false

*/

public class Solution {
    public bool IsAnagram(string s, string t) {

     // If lengths are different they can't be anagrams.
      if(s.Length != t.Length) return false;

     // Converting strings to character array
     char[] char1 = s.ToCharArray();
     char[] char2 = t.ToCharArray();

     Array.Sort(char1);
     Array.Sort(char2);

     return new string(char1).Equals(new string(char2));

    }
}