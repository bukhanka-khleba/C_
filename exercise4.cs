using System;

public class Student
{
    private string name;
    private int age;
    private int grade;

    // Конструктор
    public Student(string name, int age)
    {
        this.name = name;
        this.age = age;
        grade = 1; 
    }

    // Метод для установки оценки
    public void SetGrade(int value)
    {
        if (value >= 1 && value <= 5)
        {
            grade = value;
        }
        else
        {
            Console.WriteLine($"Ошибка: Оценка {value} должна быть в диапазоне 1-5");
        }
    }

    // Метод для вывода информации
    public void DisplayInfo()
    {
        Console.WriteLine($"Студент: {name}, Возраст: {age}, Успеваемость: {grade}");
    }
}


class exercise4
{
    static void Main()
    {
        Student student1 = new Student("Мария", 20);
        Student student2 = new Student("Иван", 22);

        student1.DisplayInfo(); 
        
        student1.SetGrade(4);   
        student1.DisplayInfo(); 
        
        student1.SetGrade(6);   
        student1.DisplayInfo(); 
        
        student2.SetGrade(3);   
        student2.DisplayInfo(); 
    }
}