// Longest Substring Without Repeating Characters


int LengthOfLongestSubstring(string s)
{
    int i = 0, j = 0, len = s.Length, maxLen = 0;
    bool[] map = new bool[128];

    while (j < len)
    {
        int current = (int)s[j];
        if (!map[current])
        {
            maxLen = Math.Max(j - i + 1, maxLen);
            map[current] = true;
            j++;
        }
        else
        {
            map[(int)s[i]] = false;
            i++;
        }
    }

    return maxLen;
}

Console.WriteLine(LengthOfLongestSubstring("dvdf"));
Console.WriteLine(LengthOfLongestSubstring("abcabcbb"));
Console.WriteLine(LengthOfLongestSubstring("bbbbb"));
Console.WriteLine(LengthOfLongestSubstring("pwwkew"));
