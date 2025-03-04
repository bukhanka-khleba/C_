public static int CountDigits(int number)
{
    if (number == 0)
        return 1;
        
    int count = 0;
    number = Math.Abs(number);
    
    while (number > 0)
    {
        count++;
        number /= 10;
    }
    
    return count;
}