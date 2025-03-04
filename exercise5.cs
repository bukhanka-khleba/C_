using System;
using System.Collections.Generic;

class exercise5
{
    static void Main()
    {
        DateTime startTime = DateTime.Now;
        int count = 0;
        
        for (int s = 1; s <= 81; s++)
        {
            int minLen = (s + 8) / 9;
            for (int len = minLen; len <= 10; len++)
            {
                List<int> numbers = new List<int>();
                GenerateNumbers(len, s, 0, new int[len], numbers);
                
                foreach (int num in numbers)
                {
                    if (num % s == 0 && num <= 1000000000)
                    {
                        count++;
                    }
                }
            }
        }
        
        DateTime endTime = DateTime.Now;
        TimeSpan elapsedTime = endTime - startTime;
        
        Console.WriteLine($"Количество хороших чисел: {count}");
        Console.WriteLine($"Время выполнения: {elapsedTime.TotalSeconds} секунд");
    }
    
    static void GenerateNumbers(int len, int sum, int pos, int[] digits, List<int> numbers)
    {
        if (pos == len)
        {
            if (sum == 0)
            {
                int number = 0;
                foreach (int d in digits)
                {
                    number = number * 10 + d;
                }
                numbers.Add(number);
            }
            return;
        }

        int start = (pos == 0) ? 1 : 0;
        int remaining = len - pos - 1;

        for (int d = start; d <= 9; d++)
        {
            int newSum = sum - d;
            if (newSum < 0 || newSum > 9 * remaining) continue;
            
            digits[pos] = d;
            GenerateNumbers(len, newSum, pos + 1, digits, numbers);
        }
    }
}