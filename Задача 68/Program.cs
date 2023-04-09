// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
Console.Clear();
int Akkerman(int m, int n)
{
    if(m == 0)
    {   
         return n+1;
    }
    if (m > 0 && n == 0)
    {
         return Akkerman(m - 1, 1);
    }
    return Akkerman(m - 1, Akkerman(m, n - 1));
}

Console.Write("Введите число M: ");//просим пользователя ввести число
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число N: ");//просим пользователя ввести число
int n = int.Parse(Console.ReadLine());
Console.WriteLine(Akkerman(m,n));