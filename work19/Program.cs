// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

    Console.WriteLine("Введите пятизначное число");
    string num = Console.ReadLine();
    int size = num.Length;
    if (size == 5)
    {
        if (num[0] == num[4] && num[1] == num[3])
        {
            Console.WriteLine("Это число полиндром");
        }
        else
        {
            Console.WriteLine("Это число не полиндром");
        }
    }
    else
    {
        Console.WriteLine("Число не пятизначное");
    }


