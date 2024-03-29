﻿  // public static double[, ] CreateRandomMatrix(int m, int n, int minLimitRandom, int maxLimitRandom) {
  //     // Введите свое решение ниже
  //   double[,] matrix = new double[m, n];
  //   for (int i=0; i < m; i++){
  //     for (int j=0; j < n; j++){
  //       matrix[i, j] = new Random().Next(minLimitRandom, maxLimitRandom) + new Random().NextDouble();
  //       }
  //   }
  //   return matrix;    
  // }

  // public static void PrintArray(double[, ] matrix) {
  //     // Введите свое решение ниже
  //     for (int i = 0; i < matrix.GetLength(0); i++){
  //       for (int j = 0; j < matrix.GetLength(1); j++){
  //         Console.Write($"{matrix[i, j]:F1} \t");
  //         }
  //         Console.WriteLine();
  //     }
  //   }

using System;

public class Answer {
    public static void PrintArray (int [,] matrix)
    {
   //      Введите свое решение ниже
      for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
          Console.Write($"{matrix[i, j]} \t");
          }
          Console.WriteLine();
      }
    }
  
    public static int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
      // Введите свое решение ниже
        int[,] matrix = new int[m, n];
        int sum = 1;
          for (int i=0; i < m; i++){
            for (int j=0; j < n; j++){
              matrix[i, j] = sum; 
              sum = sum + k;
        }
    }
    return matrix;  

    }
  
      public static int[] FindNumberByPosition (int [,] matrix, int rowPosition, int columnPosition)
      {  
    //    Введите свое решение ниже
      int [] arr = {0, 0};
      if ( rowPosition > matrix.GetLength(0) || columnPosition > matrix.GetLength(1)) arr[1] = 0;
      else {
            arr[1] = 1; 
            arr[0] =matrix[columnPosition, rowPosition] ;
           }
      return arr;
      }

     public static void PrintCheckIfError (int[] results, int X, int Y)
         {
       // Введите свое решение ниже
          if (results[1] == 0) Console.WriteLine("There is no such index");
          else Console.WriteLine($"The number in [{X}, {Y}] is {results[0]}");
         }
      

    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int n, m, k, x, y;

        if (args.Length >= 5) {
           n = int.Parse(args[0]);
           m = int.Parse(args[1]);
           k = int.Parse(args[2]);
           x = int.Parse(args[3]);
           y = int.Parse(args[4]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
           n = 3;
           m = 4;
           k = 2;
           x = 2;
           y = 3;
        }

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);
    }
}
