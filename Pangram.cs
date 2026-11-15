public static class Pangram
{
    public static bool IsPangram(string input)
    {
        HashSet<char> uniqueLetters = new HashSet<char>();
        
        string lowerInput = input.ToLower();
        
        foreach (char c in lowerInput)
        {
            if (c >= 'a' && c <= 'z')
            {
                uniqueLetters.Add(c);
            }
        }
        
        return uniqueLetters.Count == 26;
    }
}
