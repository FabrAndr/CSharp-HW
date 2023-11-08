string message = "Производится создание массива";
int[] CreateMass (string message) 
{
    int[] arr = new int[8];
    Console.WriteLine("Введите элементы массива");
   for (int i = 0; i < 8; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}


void Showmassive(int[] arr)
{
     for (int i = 0; i < 7; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[7]}");
}
int[] mass = CreateMass(message);
Showmassive(mass);
