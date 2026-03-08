// Valid Palindrome
/*
A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, it reads the same forward and backward. Alphanumeric characters include letters and numbers.

Given a string s, return true if it is a palindrome, or false otherwise.

 

Example 1:

Input: s = "A man, a plan, a canal: Panama"
Output: true
Explanation: "amanaplanacanalpanama" is a palindrome.

Example 2:

Input: s = "race a car"
Output: false
Explanation: "raceacar" is not a palindrome.

Example 3:

Input: s = " "
Output: true
Explanation: s is an empty string "" after removing non-alphanumeric characters.
Since an empty string reads the same forward and backward, it is a palindrome.

 

Constraints:

    1 <= s.length <= 2 * 105
    s consists only of printable ASCII characters.

*/

bool IsPalindrome(string s)
{
    int left = 0, n = s.Length;
    int right = n - 1;

    while (left < right)
    {
        int leftAscii = (int)s[left];
        int rightAscii = (int)s[right];

        bool leftNum = leftAscii >= 48 && leftAscii <= 57;
        bool rightNum = rightAscii >= 48 && rightAscii <= 57;

        if (leftAscii >= 65 && leftAscii <= 90 && !leftNum) leftAscii += 32;
        if (rightAscii >= 65 && rightAscii <= 90 && !rightNum) rightAscii += 32;

        if (!leftNum && (leftAscii > 122 || leftAscii < 97))
        {
            left++;
        }
        else if (!rightNum && (rightAscii > 122 || rightAscii < 97))
        {
            right--;
        }
        else if (leftAscii == rightAscii)
        {
            left++;
            right--;
        }
        else
        {
            return false;
        }
    }
    return true;
}

// Console.WriteLine(IsPalindrome("A man, a plan, a canal: Panama"));
// Console.WriteLine(IsPalindrome("race a car"));
Console.WriteLine(IsPalindrome("P0"));
