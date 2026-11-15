public static class CollatzConjecture
{
    public static int Steps(int number)
    {
        if (number <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(number), "The number must be a positive integer (greater than 0)");
        }
      
        int stepsCount = 0;
      
        while (number > 1)
        {
            if (number % 2 == 0)
            {
                number = number / 2;
            }
            else
            {
                number = (number * 3) + 1;
            }
          
            stepsCount++;
        }
      
        return stepsCount;
    }
}
