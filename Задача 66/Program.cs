// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Clear();
int SumDigital(int m, int n)
{
    if(m == n)
    {   
         return m;
    }
    return SumDigital(m+1,n)+m;
}

Console.Write("Введите число M: ");//просим пользователя ввести число
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число N: ");//просим пользователя ввести число
int n = int.Parse(Console.ReadLine());
Console.WriteLine(SumDigital(m,n));