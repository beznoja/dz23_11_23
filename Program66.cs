/*
Задайте значения M и N. Напишите программу, которая найдёт 
сумму натуральных элементов в промежутке от M до N.
*/
Console.Clear();

System.Console.WriteLine("Введите первое число: ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int intN(int m, int n)
{
    if (m<=n)
    {        
      return n+intN (m,n-1);
    }
    else 
        return 0;
}

int result = intN(number, number2);
System.Console.WriteLine(result);