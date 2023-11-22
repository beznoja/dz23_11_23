/*
Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
*/
Console.Clear();

System.Console.WriteLine("Введите первое число: ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int intN(int m, int n)
{
     if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return intN(m - 1, 1);
    }
    else
    {
        return intN(m - 1, intN(m, n - 1));
    }

}

int result = intN(number, number2);
System.Console.WriteLine(result);