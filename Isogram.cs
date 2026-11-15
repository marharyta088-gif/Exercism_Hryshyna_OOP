public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        HashSet<char> seenLetters = new HashSet<char>();
        
        string lowerWord = word.ToLower();
        
        foreach (char c in lowerWord)
        {
            if (char.IsLetter(c))
            {
                if (seenLetters.Contains(c))
                {
                    return false;
                }
                
                seenLetters.Add(c);
            }
        }
        
        return true;
    }
}
