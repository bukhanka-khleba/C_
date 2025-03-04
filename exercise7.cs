using System;

class exercise7
{
    static void Main()
    {
        // Выводим заголовок таблицы
        Console.WriteLine(" a | x |   a*sin(x)  ");
        Console.WriteLine("-----------------------");
        
        for (int i = 1; i <= 10; i++)
        {
            int a = i;
            int x = i;
            double result = a * Math.Sin(x);
            
            // Форматируем вывод для красивого отображения
            Console.WriteLine($"{a,2} | {x,2} | {result,10:F4}");
        }
    }
}