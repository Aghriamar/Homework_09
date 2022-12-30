//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные
//числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
/*
Console.Write("Please enter a positive number: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = 1;
if (n < 1)
{
    Console.WriteLine("Entered a non-positive number");
}
Console.WriteLine(Number(n, m));

int Number(int n, int m)
{
    if (n == m)
        return n;
    else
        Console.Write($"{Number(n, m + 1)}, ");
    return m;
}
*/

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт
//сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15-> 120
//M = 4; N = 8. -> 30
/*
Console.Write("Entered M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Entered N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Sum of elements from {m} to {n} = {CountSum(m, n)}");

int CountSum(int m, int n)
{
    if (m == n)
        return n;
    return n + CountSum(m, n - 1);
}
*/

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//Даны два неотрицательных числа m и n.
//m = 2, n = 3->A(m, n) = 9
//m = 3, n = 2->A(m, n) = 29
/*
Console.WriteLine("Enter two positive numbers: M & N.");
Console.Write("Entered M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Entered N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"A({m}, {n}) = {Akkerman(m, n)}");
int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}
*/