
    Console.Write("Введи трёхзначное число: ");
    int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
    if (threeDigitNumber < 0 || threeDigitNumber > 100)
    {
    string stringNumber = Convert.ToString(threeDigitNumber);
    Console.WriteLine("вторая цифра этого числа -> "+stringNumber[1]);
    }
    else Console.WriteLine("Вы ввели не 3-x значное число");
