/*
Задайте значение N. Напишите программу, которая выведет 
все натуральные числа в промежутке от N до 1. Выполнить
 с помощью рекурсии.
*/
Console.Clear();

System.Console.WriteLine("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());
int intN(int n)
{
    if (n>=2)
    {
        System.Console.Write(n+", ");
      return intN (n-1);
    }
    else 
        return 1;
}

int result = intN(number);
System.Console.WriteLine(result);