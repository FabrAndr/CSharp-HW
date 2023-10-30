    
    Console.Write("Введите номер дня недели: ");
    int  NumOfDay = Convert.ToInt32(Console.ReadLine());
    switch (NumOfDay)
    {
    case 1:
        Console.WriteLine($"{NumOfDay} -> нет");
        break;
     case 2:
        Console.WriteLine($"{NumOfDay} -> нет");
        break;
     case 3:
        Console.WriteLine($"{NumOfDay} -> нет");
        break;
     case 4:
        Console.WriteLine($"{NumOfDay} -> нет");
        break;
     case 5:
        Console.WriteLine($"{NumOfDay} -> нет");
        break;
     case 6:
        Console.WriteLine($"{NumOfDay} -> да");
        break;
     case 7:
        Console.WriteLine($"{NumOfDay} -> да");
        break;
     default:
        Console.WriteLine("В неделе только 7 дней)");
        break;
    }