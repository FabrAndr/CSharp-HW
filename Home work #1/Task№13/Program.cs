
    Console.Write("Введи число: ");
    int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
    string stringNumber = Convert.ToString(threeDigitNumber);
    if (threeDigitNumber < 0) 
    {
        Console.WriteLine("Введите положительное число)");
    }
    else
    {
        if (threeDigitNumber > 99)
        {
        Console.WriteLine($"{threeDigitNumber}-> "+stringNumber[2]);
        }
        else Console.WriteLine($"{threeDigitNumber} -> третьей цифры нет");
    }