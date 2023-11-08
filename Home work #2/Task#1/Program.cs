int ThreeDegree (int a, int b)
{
    int result = a;
    for (int i = 1; i < b; i++)
    {
        result = result * a;
    }
    return result;
}
Console.WriteLine("Введите 2 числа, первое число будет возведенно в степень второго числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int number = ThreeDegree(a, b);
Console.WriteLine(number);