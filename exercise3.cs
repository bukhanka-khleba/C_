using System;

public class Car
{
    private string brand;
    private int year;
    private int mileage;

    public Car(string brand, int year)
    {
        this.brand = brand;
        this.year = year;
        this.mileage = 0; 
    }

    public void Drive(int km)
    {
        if (km > 0)
        {
            mileage += km;
        }
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Марка: {brand}, Год выпуска: {year}, Пробег: {mileage} км");
    }

    ~Car()
    {
        Console.WriteLine($"Объект автомобиля {brand} ({year}) уничтожен.");
    }
}

class exercise3
{
    static void Main()
    {
        Car myCar = new Car("Toyota", 2020);
        myCar.DisplayInfo();
        
        myCar.Drive(150);
        myCar.DisplayInfo();
        
    }
}