public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        if (sliceLength <= 0)
        {
            throw new ArgumentException("Slice length must be greater than zero.");
        }
        
        if (string.IsNullOrEmpty(numbers))
        {
            throw new ArgumentException("String cannot be empty.");
        }
        
        if (sliceLength > numbers.Length)
        {
            throw new ArgumentException("Slice length cannot be greater than string length.");
        }
        
        List<string> result = new List<string>();
        
        for (int i = 0; i <= numbers.Length - sliceLength; i++)
        {
            result.Add(numbers.Substring(i, sliceLength));
        }
        
        return result.ToArray();
    }
}
