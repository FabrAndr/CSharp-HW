using System;

public class Answer
{
    static bool IsPalindrome(int number){
      // Введите свое решение ниже
      string num = Convert.ToString(number);
      int[] arr = new int [num.Length];
    //   for (int i = 0; i < num.Length; i++)
    //   {
    //     int g = int.Parse(num[i]);
    //     arr[i] = g;
    //     Console.WriteLine(arr[i]);
    //   }  
        int l = num.Length -1 ;
      for (int i = 0; i < num.Length; i++)
      {
        if (num[i] == num[l]) l--;
        else return false;
      }
      return true;
    }
 static bool IsFive(int number){
      // Введите свое решение ниже
      string num = Convert.ToString(number);     
      if (num.Length == 5) return true;
      else return false;  
 }
  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 6456;
        }

        // Не удаляйте строки ниже
        bool result = IsPalindrome(number);
       // System.Console.WriteLine($"{result}");
        if (IsFive(number) == true) System.Console.WriteLine($"{number} -> {result}");
        else {
             System.Console.WriteLine ($"{number} -> Число не пятизначное");
              System.Console.WriteLine (result);
             }
    }
}
