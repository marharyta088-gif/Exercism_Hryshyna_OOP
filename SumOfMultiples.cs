public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        if (max <= 1)
        {
            return 0;
        }
      
        return Enumerable.Range(1, max - 1)
            .Where(i => multiples.Any(m => m > 0 && i % m == 0))
            .Sum();
    }
}
