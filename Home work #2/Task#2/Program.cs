
int addition (string number) 
{
    int[] arr = new int[number.Length];
    int sum = 0;
    for (int i = 0; i < number.Length; i++)
    {
        arr[i] = Convert.ToInt32(number[i].ToString());
        sum = sum + arr[i];
    }
    return sum;
}

string number = Console.ReadLine();
Console.WriteLine(addition(number));