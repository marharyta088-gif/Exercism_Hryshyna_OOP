public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        var counts = new Dictionary<char, int>
        {
            ['A'] = 0,
            ['C'] = 0,
            ['G'] = 0,
            ['T'] = 0
        };
      
        foreach (char c in sequence)
        {
            switch (c)
            {
                case 'A': 
                    counts['A']++; 
                    break;
                case 'C': 
                    counts['C']++; 
                    break;
                case 'G': 
                    counts['G']++; 
                    break;
                case 'T': 
                    counts['T']++; 
                    break;
                default: 
                    throw new ArgumentException(); 
            }
        }
      
        return counts;
    }
}
