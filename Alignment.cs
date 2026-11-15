public static class LineUp
{
    public static string Format(string name, int number)
    {
        string suffix = "th";
        
        int lastTwoDigits = number % 100;
        int lastDigit = number % 10;
        if (lastTwoDigits < 11 || lastTwoDigits > 13)
        {
            switch (lastDigit)
            {
                case 1:
                    suffix = "st";
                    break;
                case 2:
                    suffix = "nd";
                    break;
                case 3:
                    suffix = "rd";
                    break;
            }
        }
        return $"{name}, you are the {number}{suffix} customer we serve today. Thank you!";
    }
}
