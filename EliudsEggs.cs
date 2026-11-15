public static class EliudsEggs
{
    public static int EggCount(int encodedCount)
    {
        int count = 0;
        while (encodedCount > 0)
        {
            encodedCount &= (encodedCount - 1);
            count++;
        }
        return count;
    }
}
